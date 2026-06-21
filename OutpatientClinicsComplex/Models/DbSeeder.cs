using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;
using OutpatientClinicsComplex.Models;

namespace OutpatientClinicsComplex
{
    public static class DbSeeder
    {
        public static void SeedData(OutpatientClinicsComplexContext context)
        {
            // إنشاء قاعدة البيانات لو مش موجودة
            context.Database.EnsureCreated();

            // لو الداتا موجودة قبل كده مش هنعمل حاجة منعاً للتكرار
            if (context.Doctors.Any()) return;

            string filePath = Path.Combine(AppContext.BaseDirectory, "clinic_data.json");
            if (!File.Exists(filePath)) return;

            try
            {
                string jsonString = File.ReadAllText(filePath);
                var root = JsonSerializer.Deserialize<JsonDatasetRoot>(jsonString);
                if (root == null) return;

                // 1. حقن الجداول الأساسية أولاً
                if (root.Doctors != null)
                {
                    context.Doctors.AddRange(root.Doctors.Select(d => new Doctor { Code = d.Code, Password = d.Password }));
                }
                if (root.Pharmacists != null)
                {
                    context.Pharmacists.AddRange(root.Pharmacists.Select(p => new Pharmacist { Code = p.Code, Password = p.Password }));
                }
                if (root.LabTechnicians != null)
                {
                    context.LabTechnicians.AddRange(root.LabTechnicians.Select(t => new LabTechnician { Code = t.Code, Password = t.Password }));
                }
                if (root.Receptionists != null)
                {
                    context.Receptionists.AddRange(root.Receptionists.Select(r => new Receptionist { Code = r.Code, Password = r.Password }));
                }
             
                context.SaveChanges(); // حفظ مستخدمين النظام الأساسيين لحساب العلاقات

                // 2. حقن سجلات المرضى (PatientHistory)
                if (root.PatientHistories != null)
                {
                    foreach (var p in root.PatientHistories)
                    {
                        context.PatientHistories.Add(new PatientHistory
                        {
                            Id = p.Id,
                            NationalId = p.NationalId,
                            FullName = p.FullName,
                            DateOfBirth = !string.IsNullOrEmpty(p.DateOfBirth) ? DateOnly.Parse(p.DateOfBirth) : null,
                            Gender = p.Gender,
                            Phone = p.Phone,
                            BloodType = p.BloodType,
                            ChronicDiseases = p.ChronicDiseases,
                            Allergies = p.Allergies,
                            DoctorCode = p.DoctorCode,
                            ReceptionistCode = p.ReceptionistCode
                        });
                    }
                    context.SaveChanges();
                }

                // 3. حقن التشخيصات (Diagnoses)
                if (root.Diagnoses != null)
                {
                    foreach (var d in root.Diagnoses)
                    {
                        context.Diagnoses.Add(new Diagnosis
                        {
                            NationalId = d.NationalId,
                            Diagnosis1 = d.DiagnosisText,
                            DoctorCode = d.DoctorCode,
                            DiagnosisDate = DateTime.Parse(d.DiagnosisDate),
                            IsDangerous = d.IsDangerous == "Yes" || d.IsDangerous == "نعم",
                            RiskLevel = d.RiskLevel,
                            Gender = d.Gender,
                            Age = d.Age,
                            LabConfirmed = d.LabConfirmed == "Yes" || d.LabConfirmed == "نعم",
                            IsReported = d.IsReported == "Yes" || d.IsReported == "نعم",
                            Month = d.Month,
                            Year = d.Year,
                            WeekNumber = d.WeekNumber
                        });
                    }
                }

                // 4. حقن المواعيد (Appointments)
                if (root.Appointments != null)
                {
                    foreach (var a in root.Appointments)
                    {
                        context.Appointments.Add(new Appointment
                        {
                            AppointmentDate = DateOnly.Parse(a.AppointmentDate),
                            StartTime = TimeOnly.Parse(a.StartTime),
                            EndTime = TimeOnly.Parse(a.EndTime),
                            DurationMinutes = a.DurationMinutes,
                            Status = a.Status,
                            ReceptionistCode = a.ReceptionistCode,
                            DoctorCode = a.DoctorCode,
                            PatientId = a.PatientId,
                            PatientNationalId = a.PatientNationalId
                        });
                    }
                }

            

                // 6. حقن الروشتات (Prescriptions)
                if (root.Prescriptions != null)
                {
                    foreach (var pr in root.Prescriptions)
                    {
                        context.Prescriptions.Add(new Prescription
                        {
                            NationalId = pr.NationalId,
                            PrescriptionDate = DateOnly.Parse(pr.PrescriptionDate),
                            Medicines = pr.Medicines,
                            Status = pr.Status,
                            DoctorCode = pr.DoctorCode,
                            PharmacistCode = pr.PharmacistCode
                        });
                    }
                }

                // 7. حقن طلبات التحاليل (RequiredTests)
                if (root.RequiredTests != null)
                {
                    foreach (var rt in root.RequiredTests)
                    {
                        context.RequiredTests.Add(new RequiredTest
                        {
                            NationalId = rt.NationalId,
                            RequestDate = DateTime.Parse(rt.RequestDate),
                            RequiredTests = rt.RequiredTestsText,
                            DoctorCode = rt.DoctorCode,
                            LabTechnicianCode = rt.LabTechnicianCode,
                            Status = rt.Status
                        });
                    }
                    context.SaveChanges();
                }

                // 8. حقن نتائج التحاليل (TestResults)
                if (root.TestResults != null)
                {
                    foreach (var tr in root.TestResults)
                    {
                        context.TestResults.Add(new TestResult
                        {
                            NationalId = tr.NationalId,
                            RequiredTestId = tr.RequiredTestId,
                            ResultTests = tr.ResultTests,
                            LabTechnicianCode = tr.LabTechnicianCode
                        });
                    }
                }

                // 1. حقن الأمراض الخطيرة
                if (root.DangerousDiseases != null)
                {
                    foreach (var dd in root.DangerousDiseases)
                    {
                        context.DangerousDiseases.Add(new DangerousDisease
                        {
                            DiseaseName = dd.DiseaseName,
                            RiskLevel = dd.RiskLevel
                        });
                    }
                }

                // 2. حقن الـ Settings (ReportSettings + OutbreakLimits مع بعض)
                if (root.Settings != null)
                {
                    foreach (var setting in root.Settings)
                    {
                        // أضف إلى ReportSettings
                        context.ReportSettings.Add(new ReportSetting
                        {
                            ReportType = setting.ReportType,
                            ReferenceDate = DateTime.Parse(setting.ReferenceDate),
                            Diagnosis = setting.Diagnosis,
                            Limit = setting.Limit
                        });

                        // أضف إلى OutbreakLimits (كل مرض ليه Limit)
                        var existingLimit = context.OutbreakLimits
                            .FirstOrDefault(l => l.Diagnosis == setting.Diagnosis);

                        if (existingLimit == null)
                        {
                            context.OutbreakLimits.Add(new OutbreakLimit
                            {
                                Diagnosis = setting.Diagnosis,
                                Limit = setting.Limit
                            });
                        }
                    }
                }

                // 3. حقن الـ OutbreakLimits الإضافية (اللي مش موجودة في Settings)
                if (root.OutbreakLimits != null)
                {
                    foreach (var ol in root.OutbreakLimits)
                    {
                        var existingLimit = context.OutbreakLimits
                            .FirstOrDefault(l => l.Diagnosis == ol.Diagnosis);

                        if (existingLimit == null)
                        {
                            context.OutbreakLimits.Add(new OutbreakLimit
                            {
                                Diagnosis = ol.Diagnosis,
                                Limit = ol.Limit
                            });
                        }
                    }
                }


                context.SaveChanges(); // حفظ كامل البيانات المتبقية دفعة واحدة بنجاح!
                Console.WriteLine("🚀 تم رفع وتغذية قاعدة البيانات بـ 14 جدول كاملين بنجاح!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"حصلت مشكلة أثناء الـ Seeding: {ex.Message}");
            }
        }
    }
}