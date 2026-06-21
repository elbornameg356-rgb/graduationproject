using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OutpatientClinicsComplex.Models;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OutpatientClinicsComplex.Services
{
    public class ReportBackgroundService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;  // ✅ اتغيرت

        public ReportBackgroundService(IServiceScopeFactory scopeFactory)  // ✅ اتغيرت
        {
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try  // ✅ إضافة try-catch
                {
                    await ProcessSurveillanceReports();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] BackgroundService Error: {ex.Message}");
                }
                await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
            }
        }

        private async Task ProcessSurveillanceReports()
        {
            using var scope = _scopeFactory.CreateScope();  // ✅ اتغيرت
            var context = scope.ServiceProvider.GetRequiredService<OutpatientClinicsComplexContext>();
            var ministryService = scope.ServiceProvider.GetRequiredService<IMinistryService>();
            var now = DateTime.Now;

            // 📅 1. التقرير اليومي (للأمراض Strong)
            var dailySetting = await context.ReportSettings
                .FirstOrDefaultAsync(s => s.ReportType.Trim() == "اليومي");

            if (dailySetting != null && now >= dailySetting.ReferenceDate.AddDays(1))
            {
                var dailyCases = await context.Diagnoses
                    .Where(d => d.RiskLevel == "Strong" && d.IsReported == false && d.DiagnosisDate >= dailySetting.ReferenceDate)
                    .ToListAsync();

                if (dailyCases.Any())
                {
                    await ministryService.SendDailyReport(dailyCases, dailySetting.ReferenceDate, now);
                    dailyCases.ForEach(c => c.IsReported = true);
                }

                dailySetting.ReferenceDate = DateTime.Today;
                await context.SaveChangesAsync();
                Console.WriteLine($"[DAILY REPORT] Sent. Cases count: {dailyCases.Count}");
            }

            // 📅 2. التقرير الأسبوعي (للأمراض Medium)
            var weeklySetting = await context.ReportSettings
                .FirstOrDefaultAsync(s => s.ReportType.Trim() == "الاسبوعي");

            if (weeklySetting != null && now >= weeklySetting.ReferenceDate.AddDays(7))
            {
                var weeklyCases = await context.Diagnoses
                    .Where(d => d.RiskLevel == "Medium" && d.IsReported == false && d.DiagnosisDate >= weeklySetting.ReferenceDate)
                    .ToListAsync();

                if (weeklyCases.Any())
                {
                    await ministryService.SendWeeklyReport(weeklyCases, weeklySetting.ReferenceDate, now);
                    weeklyCases.ForEach(c => c.IsReported = true);
                }

                weeklySetting.ReferenceDate = DateTime.Today;
                await context.SaveChangesAsync();
                Console.WriteLine($"[WEEKLY REPORT] Sent. Cases count: {weeklyCases.Count}");
            }

            // 📅 3. التقرير الشهري (للأمراض Weak)
            var monthlySetting = await context.ReportSettings
                .FirstOrDefaultAsync(s => s.ReportType.Trim() == "الشهري");

            if (monthlySetting != null && now >= monthlySetting.ReferenceDate.AddMonths(1))
            {
                var monthlyCases = await context.Diagnoses
                    .Where(d => d.RiskLevel == "Weak" && d.IsReported == false && d.DiagnosisDate >= monthlySetting.ReferenceDate)
                    .ToListAsync();

                if (monthlyCases.Any())
                {
                    await ministryService.SendMonthlyReport(monthlyCases, monthlySetting.ReferenceDate, now);
                    monthlyCases.ForEach(c => c.IsReported = true);
                }

                monthlySetting.ReferenceDate = new DateTime(now.Year, now.Month, 1);
                await context.SaveChangesAsync();
                Console.WriteLine($"[MONTHLY REPORT] Sent. Cases count: {monthlyCases.Count}");
            }
        }
    }
}

