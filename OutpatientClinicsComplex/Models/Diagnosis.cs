using System;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models;

public partial class Diagnosis
{
    public int Id { get; set; }

    public long NationalId { get; set; }

    public string Diagnosis1 { get; set; } = null!;

    public int? DoctorCode { get; set; }

    // الأعمدة الأساسية
    public DateTime DiagnosisDate { get; set; }
    public bool? IsDangerous { get; set; }
    public string? RiskLevel { get; set; }
    public string? Gender { get; set; }
    public int? Age { get; set; }
    public bool LabConfirmed { get; set; }
    public bool? IsReported { get; set; }

    // 🔴 الأعمدة اللي هتجيلك من الداتاسيت (وهتتخزن)
    public int Month { get; set; }
    public int Year { get; set; }
    public int WeekNumber { get; set; }

    public virtual Doctor? DoctorCodeNavigation { get; set; }
}