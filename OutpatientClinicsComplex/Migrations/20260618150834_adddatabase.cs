using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutpatientClinicsComplex.Migrations
{
    /// <inheritdoc />
    public partial class adddatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DangerousDiseases",
                columns: table => new
                {
                    DiseaseName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RiskLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangerousDiseases", x => x.DiseaseName);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Doctor__A25C5AA64F0D0F84", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "LabTechnician",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LabTechn__A25C5AA6D6A07C33", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "OutbreakLimits",
                columns: table => new
                {
                    Diagnosis = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Limit = table.Column<int>(type: "int", nullable: false, defaultValue: 100)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutbreakLimits", x => x.Diagnosis);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacist",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pharmaci__A25C5AA672ADC5DF", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Receptionist",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Receptio__A25C5AA604D7A5A4", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ReportSettings",
                columns: table => new
                {
                    ReportType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReferenceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Limit = table.Column<int>(type: "int", nullable: false, defaultValue: 100)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportSettings", x => new { x.ReportType, x.Diagnosis });
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalId = table.Column<long>(type: "bigint", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DoctorCode = table.Column<int>(type: "int", nullable: true),
                    DiagnosisDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDangerous = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RiskLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    LabConfirmed = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IsReported = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    WeekNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => new { x.Id, x.NationalId });
                    table.ForeignKey(
                        name: "FK_Diagnosis_Doctor",
                        column: x => x.DoctorCode,
                        principalTable: "Doctor",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "RequiredTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalId = table.Column<long>(type: "bigint", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RequiredTests = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DoctorCode = table.Column<int>(type: "int", nullable: true),
                    LabTechnicianCode = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequiredTests", x => new { x.Id, x.NationalId });
                    table.ForeignKey(
                        name: "FK_RequiredTests_Doctor",
                        column: x => x.DoctorCode,
                        principalTable: "Doctor",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_RequiredTests_LabTechnician",
                        column: x => x.LabTechnicianCode,
                        principalTable: "LabTechnician",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "TestResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalId = table.Column<long>(type: "bigint", nullable: false),
                    RequiredTestId = table.Column<int>(type: "int", nullable: false),
                    ResultTests = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LabTechnicianCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResults", x => new { x.Id, x.NationalId });
                    table.ForeignKey(
                        name: "FK_TestResults_LabTechnician",
                        column: x => x.LabTechnicianCode,
                        principalTable: "LabTechnician",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalId = table.Column<long>(type: "bigint", nullable: false),
                    PrescriptionDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Medicines = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DoctorCode = table.Column<int>(type: "int", nullable: false),
                    PharmacistCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => new { x.Id, x.NationalId });
                    table.ForeignKey(
                        name: "FK_Prescription_Doctor",
                        column: x => x.DoctorCode,
                        principalTable: "Doctor",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Prescription_Pharmacist",
                        column: x => x.PharmacistCode,
                        principalTable: "Pharmacist",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "PatientHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NationalId = table.Column<long>(type: "bigint", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BloodType = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    ChronicDiseases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorCode = table.Column<int>(type: "int", nullable: true),
                    ReceptionistCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => new { x.Id, x.NationalId });
                    table.ForeignKey(
                        name: "FK_Patient_Doctor",
                        column: x => x.DoctorCode,
                        principalTable: "Doctor",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Patient_Receptionist",
                        column: x => x.ReceptionistCode,
                        principalTable: "Receptionist",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false, defaultValue: 15),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReceptionistCode = table.Column<int>(type: "int", nullable: true),
                    DoctorCode = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    PatientNationalId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Appointm__3214EC07C9AE0B6D", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointment_Doctor",
                        column: x => x.DoctorCode,
                        principalTable: "Doctor",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Appointment_Patient",
                        columns: x => new { x.PatientId, x.PatientNationalId },
                        principalTable: "PatientHistory",
                        principalColumns: new[] { "Id", "NationalId" });
                    table.ForeignKey(
                        name: "FK_Appointment_Receptionist",
                        column: x => x.ReceptionistCode,
                        principalTable: "Receptionist",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DoctorCode",
                table: "Appointment",
                column: "DoctorCode");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientId_PatientNationalId",
                table: "Appointment",
                columns: new[] { "PatientId", "PatientNationalId" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ReceptionistCode",
                table: "Appointment",
                column: "ReceptionistCode");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_DoctorCode",
                table: "Diagnosis",
                column: "DoctorCode");

            migrationBuilder.CreateIndex(
                name: "IX_PatientHistory_DoctorCode",
                table: "PatientHistory",
                column: "DoctorCode");

            migrationBuilder.CreateIndex(
                name: "IX_PatientHistory_ReceptionistCode",
                table: "PatientHistory",
                column: "ReceptionistCode");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_DoctorCode",
                table: "Prescription",
                column: "DoctorCode");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_PharmacistCode",
                table: "Prescription",
                column: "PharmacistCode");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredTests_DoctorCode",
                table: "RequiredTests",
                column: "DoctorCode");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredTests_LabTechnicianCode",
                table: "RequiredTests",
                column: "LabTechnicianCode");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_LabTechnicianCode",
                table: "TestResults",
                column: "LabTechnicianCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "DangerousDiseases");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "OutbreakLimits");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "ReportSettings");

            migrationBuilder.DropTable(
                name: "RequiredTests");

            migrationBuilder.DropTable(
                name: "TestResults");

            migrationBuilder.DropTable(
                name: "PatientHistory");

            migrationBuilder.DropTable(
                name: "Pharmacist");

            migrationBuilder.DropTable(
                name: "LabTechnician");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Receptionist");
        }
    }
}
