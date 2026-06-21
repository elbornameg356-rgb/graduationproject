using System;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models;

public partial class RequiredTest
{
    public int Id { get; set; }

    public long NationalId { get; set; }
    public DateTime RequestDate { get; set; }
    public string RequiredTests { get; set; } = null!;

    public int? DoctorCode { get; set; }

    public int? LabTechnicianCode { get; set; }

    public string? Status { get; set; }

    public virtual Doctor? DoctorCodeNavigation { get; set; }

    public virtual LabTechnician? LabTechnicianCodeNavigation { get; set; }

}
