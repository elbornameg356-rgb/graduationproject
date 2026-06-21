using System;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models;

public partial class LabTechnician
{
    public int Code { get; set; }

    public string Password { get; set; } = null!;

    public virtual ICollection<RequiredTest> RequiredTests { get; set; } = new List<RequiredTest>();

    public virtual ICollection<TestResult> TestResults { get; set; } = new List<TestResult>();
}
