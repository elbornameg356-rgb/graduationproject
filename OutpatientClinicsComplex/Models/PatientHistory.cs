using System;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models;

public partial class PatientHistory
{
    public int Id { get; set; }

    public long NationalId { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? Phone { get; set; }

    public string? BloodType { get; set; }

    public string? ChronicDiseases { get; set; }

    public string? Allergies { get; set; }

    public int? DoctorCode { get; set; }

    public int? ReceptionistCode { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Doctor? DoctorCodeNavigation { get; set; }

    public virtual Receptionist? ReceptionistCodeNavigation { get; set; }
}
