using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutpatientClinicsComplex.Migrations
{
    /// <inheritdoc />
    public partial class adddatasetusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 1, 28711250827841L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 2, 28001081867814L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 3, 26503011407212L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 4, 28608151813117L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 5, 29901161217136L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 6, 29704260254412L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 7, 28311140135843L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 8, 29410112764219L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 9, 27102110113544L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 10, 29502112410441L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 11, 29911162058212L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 12, 26712162141143L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 13, 26012023527324L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 14, 27402190113593L });

            migrationBuilder.DeleteData(
                table: "RequiredTests",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 15, 27806130430919L });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Code", "Password" },
                values: new object[,]
                {
                    { 1, "Doc@1Pass" },
                    { 2, "Doc@2Pass" },
                    { 3, "Doc@3Pass" },
                    { 4, "Doc@4Pass" },
                    { 5, "Doc@5Pass" },
                    { 6, "Doc@6Pass" },
                    { 7, "Doc@7Pass" },
                    { 8, "Doc@8Pass" }
                });

            migrationBuilder.InsertData(
                table: "LabTechnician",
                columns: new[] { "Code", "Password" },
                values: new object[,]
                {
                    { 1, "Lab@1Pass" },
                    { 2, "Lab@2Pass" },
                    { 3, "Lab@3Pass" },
                    { 4, "Lab@4Pass" }
                });

            migrationBuilder.InsertData(
                table: "Pharmacist",
                columns: new[] { "Code", "Password" },
                values: new object[,]
                {
                    { 1, "Ph@1Pass" },
                    { 2, "Ph@2Pass" },
                    { 3, "Ph@3Pass" },
                    { 4, "Ph@4Pass" }
                });

            migrationBuilder.InsertData(
                table: "Receptionist",
                columns: new[] { "Code", "Password" },
                values: new object[,]
                {
                    { 1, "Rec@1Pass" },
                    { 2, "Rec@2Pass" },
                    { 3, "Rec@3Pass" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Code",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Code",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Code",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Code",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LabTechnician",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LabTechnician",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LabTechnician",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LabTechnician",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pharmacist",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pharmacist",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pharmacist",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pharmacist",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Receptionist",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Receptionist",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Receptionist",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "RequiredTests",
                columns: new[] { "Id", "NationalId", "DoctorCode", "LabTechnicianCode", "RequestDate", "RequiredTests", "Status" },
                values: new object[,]
                {
                    { 1, 28711250827841L, 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل وظائف الكبد", "Done" },
                    { 2, 28001081867814L, 3, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل وظائف الكلى", "Done" },
                    { 3, 26503011407212L, 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل وظائف الكبد", "Done" },
                    { 4, 28608151813117L, 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل سكر الصائم", "Done" },
                    { 5, 29901161217136L, 6, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل وظائف الكلى", "Done" },
                    { 6, 29704260254412L, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل سكر الصائم", "Done" },
                    { 7, 28311140135843L, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HbA1c تحليل", "Pending" },
                    { 8, 29410112764219L, 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل سكر الصائم", "Done" },
                    { 9, 27102110113544L, 4, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل وظائف الكبد", "Done" },
                    { 10, 29502112410441L, 5, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل وظائف الكلى", "Done" },
                    { 11, 29911162058212L, 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل وظائف الكبد", "Done" },
                    { 12, 26712162141143L, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "صورة دم كاملة CBC", "Done" },
                    { 13, 26012023527324L, 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل وظائف الكلى", "Done" },
                    { 14, 27402190113593L, 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل وظائف الكبد", "Done" },
                    { 15, 27806130430919L, 5, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحليل سكر الصائم", "Done" }
                });
        }
    }
}
