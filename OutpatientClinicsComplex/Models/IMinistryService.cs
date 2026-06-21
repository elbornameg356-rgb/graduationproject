using OutpatientClinicsComplex.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OutpatientClinicsComplex.Services
{
    public interface IMinistryService
    {
        Task SendEarlyAlert(string diagnosis, int caseCount, int limit);
        Task SendDailyReport(List<Diagnosis> cases, DateTime fromDate, DateTime toDate);
        Task SendWeeklyReport(List<Diagnosis> cases, DateTime fromDate, DateTime toDate);
        Task SendMonthlyReport(List<Diagnosis> cases, DateTime fromDate, DateTime toDate);
    }
}