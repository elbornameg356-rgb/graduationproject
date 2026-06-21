using OutpatientClinicsComplex.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientClinicsComplex.Services
{
    public class MinistryService : IMinistryService
    {
        private readonly ILogger<MinistryService> _logger;
        private readonly IEmailService _emailService;

        public MinistryService(ILogger<MinistryService> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        // 🚨 الإنذار المبكر
        public async Task SendEarlyAlert(string diagnosis, int caseCount, int limit)
        {
            var subject = $"🚨 تنبيه عاجل: تفشي مرض {diagnosis}";

            var body = $@"
            <html>
            <head>
                <style>
                    body {{ font-family: Arial, sans-serif; direction: rtl; }}
                    .alert {{ background-color: #dc3545; color: white; padding: 20px; border-radius: 10px; }}
                    .details {{ background-color: #f8f9fa; padding: 15px; border-radius: 10px; margin-top: 10px; }}
                    .warning {{ color: #dc3545; font-weight: bold; font-size: 18px; }}
                    .info {{ background-color: #fff3cd; padding: 15px; border-radius: 10px; margin-top: 10px; }}
                </style>
            </head>
            <body>
                <div class='alert'>
                    <h1>🚨 إنذار تفشي مبكر</h1>
                </div>
                
                <div class='details'>
                    <h2>📋 تفاصيل الإنذار:</h2>
                    <ul>
                        <li><strong>🦠 المرض:</strong> {diagnosis}</li>
                        <li><strong>📊 عدد الحالات الحالية:</strong> <span class='warning'>{caseCount}</span></li>
                        <li><strong>⚠️ الحد المسموح:</strong> {limit}</li>
                        <li><strong>📈 نسبة التجاوز:</strong> {((double)caseCount / limit * 100):F2}%</li>
                        <li><strong>🕐 وقت الإنذار:</strong> {DateTime.Now:yyyy-MM-dd HH:mm:ss}</li>
                    </ul>
                </div>

                <div class='info'>
                    <p style='color: #856404;'>
                        ⚠️ <strong>إجراء عاجل مطلوب:</strong> تم تجاوز الحد المسموح لهذا المرض.
                        يرجى اتخاذ الإجراءات اللازمة فوراً والتواصل مع الفريق المعني.
                    </p>
                </div>

                <hr>
                <p style='color: #666; font-size: 12px;'>
                    تم الإرسال بواسطة: نظام مجمع العيادات الخارجية<br>
                    التاريخ: {DateTime.Now:yyyy-MM-dd HH:mm:ss}
                </p>
            </body>
            </html>
            ";

            await _emailService.SendEmailAsync("", subject, body);
            _logger.LogWarning($"🚨 EARLY ALERT sent: {diagnosis} - {caseCount} cases");
        }

        // 📊 التقرير اليومي
        public async Task SendDailyReport(List<Diagnosis> cases, DateTime fromDate, DateTime toDate)
        {
            var subject = $"📊 التقرير اليومي - {DateTime.Now:yyyy-MM-dd}";

            var body = BuildDailyReportBody(cases, fromDate, toDate);
            await _emailService.SendEmailAsync("", subject, body);
            _logger.LogInformation($"📊 DAILY REPORT sent: {cases.Count} cases");
        }

        // 📈 التقرير الأسبوعي
        public async Task SendWeeklyReport(List<Diagnosis> cases, DateTime fromDate, DateTime toDate)
        {
            var weekNumber = GetWeekNumber(DateTime.Now);
            var subject = $"📈 التقرير الأسبوعي - الأسبوع {weekNumber} - {DateTime.Now:yyyy}";

            var body = BuildWeeklyReportBody(cases, fromDate, toDate);
            await _emailService.SendEmailAsync("", subject, body);
            _logger.LogInformation($"📈 WEEKLY REPORT sent: {cases.Count} cases");
        }

        // 📉 التقرير الشهري
        public async Task SendMonthlyReport(List<Diagnosis> cases, DateTime fromDate, DateTime toDate)
        {
            var subject = $"📉 التقرير الشهري - {DateTime.Now:yyyy-MM}";

            var body = BuildMonthlyReportBody(cases, fromDate, toDate);
            await _emailService.SendEmailAsync("", subject, body);
            _logger.LogInformation($"📉 MONTHLY REPORT sent: {cases.Count} cases");
        }

        // ==================== دوال بناء الإيميلات ====================

        private string BuildDailyReportBody(List<Diagnosis> cases, DateTime fromDate, DateTime toDate)
        {
            var sb = new StringBuilder();

            sb.AppendLine($@"
            <html>
            <head>
                <style>
                    body {{ font-family: Arial, sans-serif; direction: rtl; }}
                    .header {{ background-color: #007bff; color: white; padding: 20px; border-radius: 10px; }}
                    .summary {{ background-color: #e9ecef; padding: 15px; border-radius: 10px; margin-top: 10px; }}
                    table {{ width: 100%; border-collapse: collapse; margin-top: 10px; }}
                    th {{ background-color: #007bff; color: white; padding: 10px; text-align: right; }}
                    td {{ padding: 10px; border-bottom: 1px solid #ddd; }}
                    .danger {{ color: #dc3545; font-weight: bold; }}
                    .gender-m {{ color: #007bff; }}
                    .gender-f {{ color: #dc3545; }}
                </style>
            </head>
            <body>
                <div class='header'>
                    <h1>📊 التقرير اليومي</h1>
                    <p>الأمراض ذات الخطورة العالية (Strong)</p>
                </div>

                <div class='summary'>
                    <h3>📋 ملخص التقرير:</h3>
                    <ul>
                        <li><strong>📅 الفترة:</strong> من {fromDate:yyyy-MM-dd} إلى {toDate:yyyy-MM-dd}</li>
                        <li><strong>👥 إجمالي الحالات:</strong> {cases.Count}</li>
                    </ul>
                </div>
            ");

            if (cases.Any())
            {
                sb.AppendLine(@"
                <h3>📋 تفاصيل الحالات:</h3>
                <table>
                    <thead>
                        <tr>
                            <th>الرقم القومي</th>
                            <th>التشخيص</th>
                            <th>العمر</th>
                            <th>الجنس</th>
                            <th>تأكيد معملي</th>
                            <th>التاريخ</th>
                        </tr>
                    </thead>
                    <tbody>
                ");

                foreach (var c in cases)
                {
                    sb.AppendLine($@"
                        <tr>
                            <td>{c.NationalId}</td>
                            <td>{c.Diagnosis1}</td>
                            <td>{c.Age}</td>
                            <td class='{(c.Gender == "Male" ? "gender-m" : "gender-f")}'>{c.Gender}</td>
                            <td>{(c.LabConfirmed ? "✅ نعم" : "❌ لا")}</td>
                            <td>{c.DiagnosisDate:yyyy-MM-dd HH:mm}</td>
                        </tr>
                    ");
                }

                sb.AppendLine("</tbody></table>");
            }
            else
            {
                sb.AppendLine("<p style='color: #666;'>⚠️ لا توجد حالات جديدة اليوم</p>");
            }

            sb.AppendLine($@"
                <hr>
                <p style='color: #666; font-size: 12px;'>
                    تم الإرسال بواسطة: نظام مجمع العيادات الخارجية<br>
                    التاريخ: {DateTime.Now:yyyy-MM-dd HH:mm:ss}
                </p>
            </body>
            </html>
            ");

            return sb.ToString();
        }

        private string BuildWeeklyReportBody(List<Diagnosis> cases, DateTime fromDate, DateTime toDate)
        {
            var sb = new StringBuilder();

            sb.AppendLine($@"
            <html>
            <head>
                <style>
                    body {{ font-family: Arial, sans-serif; direction: rtl; }}
                    .header {{ background-color: #28a745; color: white; padding: 20px; border-radius: 10px; }}
                    .summary {{ background-color: #e9ecef; padding: 15px; border-radius: 10px; margin-top: 10px; }}
                    table {{ width: 100%; border-collapse: collapse; margin-top: 10px; }}
                    th {{ background-color: #28a745; color: white; padding: 10px; text-align: right; }}
                    td {{ padding: 10px; border-bottom: 1px solid #ddd; }}
                </style>
            </head>
            <body>
                <div class='header'>
                    <h1>📈 التقرير الأسبوعي</h1>
                    <p>الأمراض ذات الخطورة المتوسطة (Medium) - الأسبوع {GetWeekNumber(DateTime.Now)}</p>
                </div>

                <div class='summary'>
                    <h3>📋 ملخص التقرير:</h3>
                    <ul>
                        <li><strong>📅 الفترة:</strong> من {fromDate:yyyy-MM-dd} إلى {toDate:yyyy-MM-dd}</li>
                        <li><strong>👥 إجمالي الحالات:</strong> {cases.Count}</li>
                    </ul>
                </div>
            ");

            if (cases.Any())
            {
                sb.AppendLine(@"
                <h3>📋 تفاصيل الحالات:</h3>
                <table>
                    <thead>
                        <tr>
                            <th>الرقم القومي</th>
                            <th>التشخيص</th>
                            <th>العمر</th>
                            <th>الجنس</th>
                            <th>الفئة العمرية</th>
                        </tr>
                    </thead>
                    <tbody>
                ");

                foreach (var c in cases)
                {
                    sb.AppendLine($@"
                        <tr>
                            <td>{c.NationalId}</td>
                            <td>{c.Diagnosis1}</td>
                            <td>{c.Age}</td>
                            <td>{c.Gender}</td>
                            <td>{GetAgeGroup(c.Age ?? 0)}</td>
                        </tr>
                    ");
                }

                sb.AppendLine("</tbody></table>");
            }
            else
            {
                sb.AppendLine("<p style='color: #666;'>⚠️ لا توجد حالات جديدة هذا الأسبوع</p>");
            }

            sb.AppendLine($@"
                <hr>
                <p style='color: #666; font-size: 12px;'>
                    تم الإرسال بواسطة: نظام مجمع العيادات الخارجية<br>
                    التاريخ: {DateTime.Now:yyyy-MM-dd HH:mm:ss}
                </p>
            </body>
            </html>
            ");

            return sb.ToString();
        }

        private string BuildMonthlyReportBody(List<Diagnosis> cases, DateTime fromDate, DateTime toDate)
        {
            var sb = new StringBuilder();

            // مجموعات حسب الفئة العمرية
            var ageGroups = cases.GroupBy(c => GetAgeGroup(c.Age ?? 0))
                .Select(g => new { AgeGroup = g.Key, Count = g.Count() })
                .OrderBy(g => g.AgeGroup);

            sb.AppendLine($@"
            <html>
            <head>
                <style>
                    body {{ font-family: Arial, sans-serif; direction: rtl; }}
                    .header {{ background-color: #17a2b8; color: white; padding: 20px; border-radius: 10px; }}
                    .summary {{ background-color: #e9ecef; padding: 15px; border-radius: 10px; margin-top: 10px; }}
                    table {{ width: 100%; border-collapse: collapse; margin-top: 10px; }}
                    th {{ background-color: #17a2b8; color: white; padding: 10px; text-align: right; }}
                    td {{ padding: 10px; border-bottom: 1px solid #ddd; }}
                    .stats {{ background-color: #d1ecf1; padding: 10px; border-radius: 10px; margin-top: 10px; }}
                </style>
            </head>
            <body>
                <div class='header'>
                    <h1>📉 التقرير الشهري</h1>
                    <p>الأمراض ذات الخطورة المنخفضة (Weak) - {DateTime.Now:MMMM yyyy}</p>
                </div>

                <div class='summary'>
                    <h3>📋 ملخص التقرير:</h3>
                    <ul>
                        <li><strong>📅 الفترة:</strong> من {fromDate:yyyy-MM-dd} إلى {toDate:yyyy-MM-dd}</li>
                        <li><strong>👥 إجمالي الحالات:</strong> {cases.Count}</li>
                    </ul>
                </div>
            ");

            // إحصائيات حسب الفئة العمرية
            if (cases.Any())
            {
                sb.AppendLine(@"
                <div class='stats'>
                    <h4>📊 توزيع الحالات حسب الفئة العمرية:</h4>
                    <ul>
                ");

                foreach (var group in ageGroups)
                {
                    sb.AppendLine($"<li><strong>{group.AgeGroup}:</strong> {group.Count} حالة</li>");
                }

                sb.AppendLine("</ul></div>");

                sb.AppendLine(@"
                <h3>📋 تفاصيل الحالات:</h3>
                <table>
                    <thead>
                        <tr>
                            <th>الرقم القومي</th>
                            <th>التشخيص</th>
                            <th>الشهر</th>
                            <th>السنة</th>
                            <th>الجنس</th>
                            <th>الفئة العمرية</th>
                        </tr>
                    </thead>
                    <tbody>
                ");

                foreach (var c in cases)
                {
                    sb.AppendLine($@"
                        <tr>
                            <td>{c.NationalId}</td>
                            <td>{c.Diagnosis1}</td>
                            <td>{c.Month}</td>
                            <td>{c.Year}</td>
                            <td>{c.Gender}</td>
                            <td>{GetAgeGroup(c.Age ?? 0)}</td>
                        </tr>
                    ");
                }

                sb.AppendLine("</tbody></table>");
            }
            else
            {
                sb.AppendLine("<p style='color: #666;'>⚠️ لا توجد حالات جديدة هذا الشهر</p>");
            }

            sb.AppendLine($@"
                <hr>
                <p style='color: #666; font-size: 12px;'>
                    تم الإرسال بواسطة: نظام مجمع العيادات الخارجية<br>
                    التاريخ: {DateTime.Now:yyyy-MM-dd HH:mm:ss}
                </p>
            </body>
            </html>
            ");

            return sb.ToString();
        }

        // ==================== دوال مساعدة ====================

        private int GetWeekNumber(DateTime date)
        {
            var culture = System.Globalization.CultureInfo.InvariantCulture;
            return culture.Calendar.GetWeekOfYear(date,
                System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private string GetAgeGroup(int age)
        {
            if (age < 10) return "0-9";
            if (age < 20) return "10-19";
            if (age < 30) return "20-29";
            if (age < 40) return "30-39";
            if (age < 50) return "40-49";
            if (age < 60) return "50-59";
            if (age < 70) return "60-69";
            if (age < 80) return "70-79";
            return "80+";
        }
    }
}

