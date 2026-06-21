using System;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models;

public partial class Pharmacist
{
    public int Code { get; set; }

    public string Password { get; set; } = null!;

    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}
