using System;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models;

public partial class Doctor
{
    public int Code { get; set; }

    public string Password { get; set; } = null!;

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

   

    public virtual ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();

    public virtual ICollection<PatientHistory> PatientHistories { get; set; } = new List<PatientHistory>();

    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    public virtual ICollection<RequiredTest> RequiredTests { get; set; } = new List<RequiredTest>();
}
