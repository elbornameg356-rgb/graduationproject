using System;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models;

public partial class Receptionist
{
    public int Code { get; set; }

    public string Password { get; set; } = null!;

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<PatientHistory> PatientHistories { get; set; } = new List<PatientHistory>();
}
