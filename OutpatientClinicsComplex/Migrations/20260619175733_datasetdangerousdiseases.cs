using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutpatientClinicsComplex.Migrations
{
    /// <inheritdoc />
    public partial class datasetdangerousdiseases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DangerousDiseases",
                columns: new[] { "DiseaseName", "RiskLevel" },
                values: new object[,]
                {
                    { "إنفلونزا الطيور", "Strong" },
                    { "التسمم الغذائي", "Weak" },
                    { "التهاب السحايا البكتيري", "Medium" },
                    { "التهاب الكبد A", "Medium" },
                    { "التهاب الكبد B", "Medium" },
                    { "التهاب الكبد C", "Medium" },
                    { "الجدري المائي", "Weak" },
                    { "الجمرة الخبيثة", "Strong" },
                    { "الحصبة", "Medium" },
                    { "الحصبة الألمانية", "Medium" },
                    { "الحمى التيفودية", "Medium" },
                    { "الحمى الصفراء", "Strong" },
                    { "الحمى النزفية الفيروسية", "Strong" },
                    { "الدفتيريا", "Medium" },
                    { "السعال الديكي", "Weak" },
                    { "السل الرئوي", "Medium" },
                    { "الطاعون", "Strong" },
                    { "الكوليرا", "Strong" },
                    { "الملاريا", "Medium" },
                    { "النكاف", "Weak" },
                    { "حمى الضنك", "Medium" },
                    { "شلل الأطفال", "Strong" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "إنفلونزا الطيور");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "التسمم الغذائي");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "التهاب السحايا البكتيري");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "التهاب الكبد A");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "التهاب الكبد B");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "التهاب الكبد C");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الجدري المائي");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الجمرة الخبيثة");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الحصبة");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الحصبة الألمانية");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الحمى التيفودية");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الحمى الصفراء");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الحمى النزفية الفيروسية");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الدفتيريا");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "السعال الديكي");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "السل الرئوي");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الطاعون");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الكوليرا");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "الملاريا");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "النكاف");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "حمى الضنك");

            migrationBuilder.DeleteData(
                table: "DangerousDiseases",
                keyColumn: "DiseaseName",
                keyValue: "شلل الأطفال");
        }
    }
}
