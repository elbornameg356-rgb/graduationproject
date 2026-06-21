using System;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models;

public partial class Prescription
{
    public int Id { get; set; }

    public long NationalId { get; set; }
    public DateOnly PrescriptionDate { get; set; }
    public string Medicines { get; set; } = null!;

    public string? Status { get; set; }

    public int DoctorCode { get; set; }

    public int? PharmacistCode { get; set; }

    public virtual Doctor DoctorCodeNavigation { get; set; } = null!;

    public virtual Pharmacist? PharmacistCodeNavigation { get; set; }
}
