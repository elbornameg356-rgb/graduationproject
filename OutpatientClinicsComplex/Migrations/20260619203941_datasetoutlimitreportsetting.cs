using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutpatientClinicsComplex.Migrations
{
    /// <inheritdoc />
    public partial class datasetoutlimitreportsetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OutbreakLimits",
                columns: new[] { "Diagnosis", "Limit" },
                values: new object[,]
                {
                    { "آلام الظهر المزمنة", 1000 },
                    { "إنفلونزا الطيور", 2 },
                    { "ارتفاع ضغط الدم", 1000 },
                    { "الأنيميا", 1000 },
                    { "التسمم الغذائي", 3 },
                    { "التهاب الأذن الوسطى", 1000 },
                    { "التهاب الجيوب الأنفية", 1000 },
                    { "التهاب السحايا البكتيري", 1 },
                    { "التهاب الكبد A", 3 },
                    { "التهاب الكبد B", 1000 },
                    { "التهاب الكبد C", 1000 },
                    { "التهاب اللوزتين الحاد", 15 },
                    { "التهاب المسالك البولية", 1000 },
                    { "التهاب المعدة والأمعاء", 10 },
                    { "التهاب المفاصل", 1000 },
                    { "التهاب في الجهاز التنفسي العلوي", 20 },
                    { "الجدري المائي", 3 },
                    { "الجمرة الخبيثة", 1 },
                    { "الحصبة", 2 },
                    { "الحصبة الألمانية", 2 },
                    { "الحموضة وارتجاع المريء", 1000 },
                    { "الحمى التيفودية", 3 },
                    { "الحمى الصفراء", 1 },
                    { "الحمى النزفية الفيروسية", 1 },
                    { "الدفتيريا", 1 },
                    { "الربو القصبي", 1000 },
                    { "السعال الديكي", 2 },
                    { "السل الرئوي", 2 },
                    { "الصداع النصفي", 1000 },
                    { "الطاعون", 1 },
                    { "الكوليرا", 1 },
                    { "الملاريا", 2 },
                    { "النكاف", 2 },
                    { "حمى الضنك", 2 },
                    { "شلل الأطفال", 1 },
                    { "قصور الغدة الدرقية", 1000 },
                    { "مرض السكري النوع الثاني", 1000 }
                });

            migrationBuilder.InsertData(
                table: "ReportSettings",
                columns: new[] { "Diagnosis", "ReportType", "Limit", "ReferenceDate" },
                values: new object[,]
                {
                    { "الطاعون", "الاسبوعي", 1, new DateTime(2026, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "التهاب الجيوب الأنفية", "الشهري", 1000, new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "الأنيميا", "اليومي", 1000, new DateTime(2026, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "آلام الظهر المزمنة");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "إنفلونزا الطيور");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "ارتفاع ضغط الدم");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الأنيميا");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التسمم الغذائي");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب الأذن الوسطى");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب الجيوب الأنفية");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب السحايا البكتيري");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب الكبد A");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب الكبد B");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب الكبد C");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب اللوزتين الحاد");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب المسالك البولية");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب المعدة والأمعاء");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب المفاصل");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "التهاب في الجهاز التنفسي العلوي");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الجدري المائي");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الجمرة الخبيثة");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الحصبة");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الحصبة الألمانية");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الحموضة وارتجاع المريء");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الحمى التيفودية");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الحمى الصفراء");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الحمى النزفية الفيروسية");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الدفتيريا");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الربو القصبي");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "السعال الديكي");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "السل الرئوي");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الصداع النصفي");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الطاعون");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الكوليرا");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "الملاريا");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "النكاف");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "حمى الضنك");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "شلل الأطفال");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "قصور الغدة الدرقية");

            migrationBuilder.DeleteData(
                table: "OutbreakLimits",
                keyColumn: "Diagnosis",
                keyValue: "مرض السكري النوع الثاني");

            migrationBuilder.DeleteData(
                table: "ReportSettings",
                keyColumns: new[] { "Diagnosis", "ReportType" },
                keyValues: new object[] { "الطاعون", "الاسبوعي" });

            migrationBuilder.DeleteData(
                table: "ReportSettings",
                keyColumns: new[] { "Diagnosis", "ReportType" },
                keyValues: new object[] { "التهاب الجيوب الأنفية", "الشهري" });

            migrationBuilder.DeleteData(
                table: "ReportSettings",
                keyColumns: new[] { "Diagnosis", "ReportType" },
                keyValues: new object[] { "الأنيميا", "اليومي" });
        }
    }
}
