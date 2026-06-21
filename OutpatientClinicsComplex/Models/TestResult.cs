using System;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models;

public partial class TestResult
{
    public int Id { get; set; }


    public long NationalId { get; set; }

    public int RequiredTestId { get; set; }

    public string ResultTests { get; set; } = null!;

    public int? LabTechnicianCode { get; set; }

    public virtual LabTechnician? LabTechnicianCodeNavigation { get; set; }
}
