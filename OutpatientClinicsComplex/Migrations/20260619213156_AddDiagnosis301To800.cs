using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutpatientClinicsComplex.Migrations
{
    /// <inheritdoc />
    public partial class AddDiagnosis301To800 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "NationalId", "Age", "Diagnosis", "DiagnosisDate", "DoctorCode", "Gender", "IsDangerous", "IsReported", "LabConfirmed", "Month", "RiskLevel", "WeekNumber", "Year" },
                values: new object[,]
                {
                    { 301, 27908091222948L, 46, "التهاب المعدة والأمعاء", new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 7, "Not Dangerous", 29, 2025 },
                    { 302, 26902091750426L, 57, "الصداع النصفي", new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 303, 26301141133025L, 63, "التهاب اللوزتين الحاد", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 11, "Not Dangerous", 45, 2025 },
                    { 304, 26504110427215L, 61, "مرض السكري النوع الثاني", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 2, "Not Dangerous", 6, 2025 },
                    { 305, 28010032251413L, 45, "الربو القصبي", new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 4, "Not Dangerous", 16, 2025 },
                    { 306, 28108270433316L, 44, "ارتفاع ضغط الدم", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 6, "Not Dangerous", 23, 2025 },
                    { 307, 27306201560027L, 52, "الأنيميا", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 308, 26512100991915L, 60, "التهاب المعدة والأمعاء", new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 12, "Not Dangerous", 52, 2025 },
                    { 309, 26703070444031L, 59, "ارتفاع ضغط الدم", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 3, "Not Dangerous", 12, 2025 },
                    { 310, 29412240719842L, 31, "الربو القصبي", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 10, "Not Dangerous", 41, 2025 },
                    { 311, 27207010318911L, 53, "التهاب المفاصل", new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 4, "Not Dangerous", 14, 2025 },
                    { 312, 26711271888735L, 58, "الربو القصبي", new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 8, "Not Dangerous", 31, 2025 },
                    { 313, 27909242476921L, 46, "مرض السكري النوع الثاني", new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 314, 26509160450543L, 60, "الحمى النزفية الفيروسية", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, true, 6, "Strong", 24, 2025 },
                    { 315, 26509160450543L, 60, "الصداع النصفي", new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 5, "Not Dangerous", 19, 2025 },
                    { 316, 28810260432426L, 37, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 12, "Not Dangerous", 50, 2025 },
                    { 317, 29208011553646L, 33, "الكوليرا", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, false, 6, "Strong", 26, 2025 },
                    { 318, 25707260961746L, 68, "التهاب الأذن الوسطى", new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 8, "Not Dangerous", 31, 2025 },
                    { 319, 27609081887333L, 49, "التهاب الأذن الوسطى", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 320, 29204201910821L, 34, "السل الرئوي", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 8, "Medium", 35, 2025 },
                    { 321, 27403050139245L, 52, "التهاب الجيوب الأنفية", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 322, 27612260840312L, 49, "الجمرة الخبيثة", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, false, 4, "Strong", 17, 2025 },
                    { 323, 29707182119014L, 28, "التهاب اللوزتين الحاد", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 324, 29004121325013L, 36, "النكاف", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", true, true, false, 2, "Weak", 6, 2025 },
                    { 325, 29606140660042L, 29, "التهاب المفاصل", new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 326, 29507060598135L, 30, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 10, "Not Dangerous", 42, 2025 },
                    { 327, 29502011495033L, 31, "التهاب المعدة والأمعاء", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, true, 6, "Not Dangerous", 24, 2025 },
                    { 328, 28406122061644L, 41, "الربو القصبي", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 9, "Not Dangerous", 37, 2025 },
                    { 329, 26401090945534L, 62, "الصداع النصفي", new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 330, 27211090568942L, 53, "التسمم الغذائي", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, true, 8, "Weak", 32, 2025 },
                    { 331, 28109192219726L, 44, "الحموضة وارتجاع المريء", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 332, 28304140940528L, 43, "التهاب المسالك البولية", new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, true, 12, "Not Dangerous", 51, 2025 },
                    { 333, 26601172079928L, 60, "التهاب الجيوب الأنفية", new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 4, "Not Dangerous", 15, 2025 },
                    { 334, 29602061327126L, 30, "التهاب المفاصل", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, true, 4, "Not Dangerous", 15, 2025 },
                    { 335, 30312031681246L, 22, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, true, 5, "Not Dangerous", 21, 2025 },
                    { 336, 26004251794235L, 66, "الأنيميا", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 337, 26601230933711L, 60, "آلام الظهر المزمنة", new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 5, "Not Dangerous", 21, 2025 },
                    { 338, 27206150576843L, 53, "الربو القصبي", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 339, 25504242411534L, 71, "قصور الغدة الدرقية", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 12, "Not Dangerous", 51, 2025 },
                    { 340, 28608180783613L, 39, "ارتفاع ضغط الدم", new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 10, "Not Dangerous", 41, 2025 },
                    { 341, 28111090662438L, 44, "قصور الغدة الدرقية", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 342, 25805240820423L, 68, "التهاب السحايا البكتيري", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 9, "Medium", 39, 2025 },
                    { 343, 30207202760829L, 23, "ارتفاع ضغط الدم", new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 344, 28111090662438L, 44, "النكاف", new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", true, true, false, 2, "Weak", 8, 2025 },
                    { 345, 26012032527324L, 65, "آلام الظهر المزمنة", new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 346, 28908152583844L, 36, "التهاب المسالك البولية", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 2, "Not Dangerous", 8, 2025 },
                    { 347, 27909242476921L, 46, "الصداع النصفي", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 11, "Not Dangerous", 48, 2025 },
                    { 348, 29609162011614L, 29, "مرض السكري النوع الثاني", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 1, "Not Dangerous", 2, 2025 },
                    { 349, 30512242187043L, 20, "الربو القصبي", new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 12, "Not Dangerous", 50, 2025 },
                    { 350, 27110191267934L, 54, "التهاب المسالك البولية", new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 4, "Not Dangerous", 17, 2025 },
                    { 351, 27402270257328L, 52, "التهاب المفاصل", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 10, "Not Dangerous", 42, 2025 },
                    { 352, 26102161683017L, 65, "الربو القصبي", new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 11, "Not Dangerous", 46, 2025 },
                    { 353, 26311211430532L, 62, "الحموضة وارتجاع المريء", new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 4, "Not Dangerous", 17, 2025 },
                    { 354, 26210200423442L, 63, "التهاب الأذن الوسطى", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 10, "Not Dangerous", 43, 2025 },
                    { 355, 29902021581915L, 27, "الحموضة وارتجاع المريء", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 356, 25501091671433L, 71, "التهاب الجيوب الأنفية", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 357, 30402041591623L, 22, "آلام الظهر المزمنة", new DateTime(2025, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 9, "Not Dangerous", 36, 2025 },
                    { 358, 25911201723239L, 66, "آلام الظهر المزمنة", new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 10, "Not Dangerous", 42, 2025 },
                    { 359, 27111250166317L, 54, "النكاف", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, true, true, 2, "Weak", 7, 2025 },
                    { 360, 28506221177223L, 40, "الملاريا", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", true, true, true, 8, "Medium", 32, 2025 },
                    { 361, 29502200562115L, 31, "قصور الغدة الدرقية", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 4, "Not Dangerous", 14, 2025 },
                    { 362, 27011140332648L, 55, "آلام الظهر المزمنة", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 363, 28101061646726L, 45, "التهاب المفاصل", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 364, 27611162373234L, 49, "الربو القصبي", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 3, "Not Dangerous", 12, 2025 },
                    { 365, 28409091494121L, 41, "آلام الظهر المزمنة", new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 7, "Not Dangerous", 28, 2025 },
                    { 366, 29104112764219L, 35, "التهاب المعدة والأمعاء", new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 7, "Not Dangerous", 28, 2025 },
                    { 367, 28409091494121L, 41, "الصداع النصفي", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 3, "Not Dangerous", 13, 2025 },
                    { 368, 27301211520721L, 53, "النكاف", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", true, true, false, 2, "Weak", 6, 2025 },
                    { 369, 30502011419048L, 21, "التهاب الجيوب الأنفية", new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 10, "Not Dangerous", 44, 2025 },
                    { 370, 29602101223226L, 30, "مرض السكري النوع الثاني", new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 371, 28910080232534L, 36, "التهاب اللوزتين الحاد", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 372, 28312052272832L, 42, "التهاب الجيوب الأنفية", new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 4, "Not Dangerous", 14, 2025 },
                    { 373, 27807060786621L, 47, "التهاب المعدة والأمعاء", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 12, "Not Dangerous", 49, 2025 },
                    { 374, 26311042578026L, 62, "آلام الظهر المزمنة", new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 375, 26710050560525L, 58, "الأنيميا", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, true, 8, "Not Dangerous", 34, 2025 },
                    { 376, 29609181438041L, 29, "التهاب الكبد B", new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", true, true, false, 11, "Medium", 47, 2025 },
                    { 377, 28310131632728L, 42, "قصور الغدة الدرقية", new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 378, 29412240719842L, 31, "قصور الغدة الدرقية", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 10, "Not Dangerous", 40, 2025 },
                    { 379, 28101061646726L, 45, "التهاب المسالك البولية", new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 380, 27109132788216L, 54, "ارتفاع ضغط الدم", new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 381, 28408161691518L, 41, "مرض السكري النوع الثاني", new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 12, "Not Dangerous", 49, 2025 },
                    { 382, 26307020364649L, 62, "الأنيميا", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 12, "Not Dangerous", 51, 2025 },
                    { 383, 29906031231545L, 27, "التهاب الأذن الوسطى", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 384, 29208011553646L, 33, "التهاب الجيوب الأنفية", new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 8, "Not Dangerous", 32, 2025 },
                    { 385, 28111090662438L, 44, "التهاب المفاصل", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 386, 26304081958943L, 63, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 3, "Not Dangerous", 11, 2025 },
                    { 387, 29609162011614L, 29, "ارتفاع ضغط الدم", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 10, "Not Dangerous", 43, 2025 },
                    { 388, 25906261624719L, 66, "قصور الغدة الدرقية", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 389, 29508250646133L, 30, "التهاب الأذن الوسطى", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 6, "Not Dangerous", 24, 2025 },
                    { 390, 27402270257328L, 52, "التهاب المفاصل", new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 391, 30203062369321L, 24, "الكوليرا", new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", true, true, false, 7, "Strong", 27, 2025 },
                    { 392, 27501121188627L, 51, "التهاب المفاصل", new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 393, 27511261744633L, 50, "التهاب اللوزتين الحاد", new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 3, "Not Dangerous", 12, 2025 },
                    { 394, 27206150576843L, 53, "الربو القصبي", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 4, "Not Dangerous", 14, 2025 },
                    { 395, 28606280831448L, 39, "الصداع النصفي", new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, true, 12, "Not Dangerous", 50, 2025 },
                    { 396, 26011271939936L, 65, "قصور الغدة الدرقية", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 1, "Not Dangerous", 3, 2025 },
                    { 397, 27412110150319L, 51, "الحموضة وارتجاع المريء", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 1, "Not Dangerous", 3, 2025 },
                    { 398, 25804031762917L, 68, "التهاب المعدة والأمعاء", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 11, "Not Dangerous", 45, 2025 },
                    { 399, 29902021581915L, 27, "الحموضة وارتجاع المريء", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 5, "Not Dangerous", 22, 2025 },
                    { 400, 26909112682924L, 56, "الحموضة وارتجاع المريء", new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 8, "Not Dangerous", 32, 2025 },
                    { 401, 26906132195932L, 56, "التسمم الغذائي", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 9, "Weak", 37, 2025 },
                    { 402, 30412130970331L, 21, "قصور الغدة الدرقية", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 7, "Not Dangerous", 27, 2025 },
                    { 403, 26305201632248L, 63, "التهاب الأذن الوسطى", new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 5, "Not Dangerous", 21, 2025 },
                    { 404, 26007120337426L, 65, "التهاب المفاصل", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 2, "Not Dangerous", 8, 2025 },
                    { 405, 26509130297918L, 60, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 8, "Not Dangerous", 32, 2025 },
                    { 406, 28404172440533L, 42, "الحموضة وارتجاع المريء", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 2, "Not Dangerous", 6, 2025 },
                    { 407, 30406152649934L, 21, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 4, "Not Dangerous", 17, 2025 },
                    { 408, 29508250646133L, 30, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 10, "Not Dangerous", 44, 2025 },
                    { 409, 29805050237031L, 28, "قصور الغدة الدرقية", new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 4, "Not Dangerous", 17, 2025 },
                    { 410, 26812252287219L, 57, "الحموضة وارتجاع المريء", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 1, "Not Dangerous", 1, 2025 },
                    { 411, 27710080619122L, 48, "التهاب المسالك البولية", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 8, "Not Dangerous", 33, 2025 },
                    { 412, 29203081458321L, 34, "الحموضة وارتجاع المريء", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 6, "Not Dangerous", 25, 2025 },
                    { 413, 29009180595917L, 35, "قصور الغدة الدرقية", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 10, "Not Dangerous", 41, 2025 },
                    { 414, 29102280933313L, 35, "النكاف", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", true, true, true, 2, "Weak", 8, 2025 },
                    { 415, 27403240425049L, 52, "آلام الظهر المزمنة", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 416, 26512160881922L, 60, "ارتفاع ضغط الدم", new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 11, "Not Dangerous", 46, 2025 },
                    { 417, 29402051031646L, 32, "الصداع النصفي", new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 7, "Not Dangerous", 30, 2025 },
                    { 418, 28209230772216L, 43, "التهاب الأذن الوسطى", new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 4, "Not Dangerous", 15, 2025 },
                    { 419, 27206150576843L, 53, "قصور الغدة الدرقية", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 9, "Not Dangerous", 37, 2025 },
                    { 420, 30404280672735L, 22, "الربو القصبي", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 421, 26606160353115L, 59, "الصداع النصفي", new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 422, 28412052161645L, 41, "آلام الظهر المزمنة", new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 12, "Not Dangerous", 49, 2025 },
                    { 423, 29409112072647L, 31, "الأنيميا", new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 424, 29610040117014L, 29, "التهاب اللوزتين الحاد", new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 10, "Not Dangerous", 42, 2025 },
                    { 425, 29304071787113L, 33, "الصداع النصفي", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 426, 28409250963939L, 41, "التهاب الأذن الوسطى", new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 7, "Not Dangerous", 28, 2025 },
                    { 427, 29211271336524L, 33, "الحموضة وارتجاع المريء", new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 6, "Not Dangerous", 23, 2025 },
                    { 428, 30311020977349L, 22, "قصور الغدة الدرقية", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 2, "Not Dangerous", 5, 2025 },
                    { 429, 27511261744633L, 50, "التسمم الغذائي", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, true, 6, "Weak", 24, 2025 },
                    { 430, 26105142352636L, 65, "الحصبة الألمانية", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 6, "Medium", 25, 2025 },
                    { 431, 29105160449241L, 35, "التهاب المفاصل", new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 9, "Not Dangerous", 39, 2025 },
                    { 432, 28910080232534L, 36, "الأنيميا", new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 4, "Not Dangerous", 15, 2025 },
                    { 433, 29009180595917L, 35, "مرض السكري النوع الثاني", new DateTime(2025, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 434, 29604192279134L, 30, "الحمى التيفودية", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, true, false, 5, "Medium", 20, 2025 },
                    { 435, 29211271336524L, 33, "الحموضة وارتجاع المريء", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 10, "Not Dangerous", 41, 2025 },
                    { 436, 30502011419048L, 21, "التهاب الأذن الوسطى", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 2, "Not Dangerous", 6, 2025 },
                    { 437, 27403240425049L, 52, "الملاريا", new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", true, true, false, 5, "Medium", 20, 2025 },
                    { 438, 29707140611316L, 28, "الحموضة وارتجاع المريء", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 439, 28109192219726L, 44, "ارتفاع ضغط الدم", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 440, 29410222120936L, 31, "الكوليرا", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, false, 10, "Strong", 42, 2025 },
                    { 441, 26512100991915L, 60, "التهاب الجيوب الأنفية", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 3, "Not Dangerous", 10, 2025 },
                    { 442, 28103212755522L, 45, "التهاب المسالك البولية", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 5, "Not Dangerous", 20, 2025 },
                    { 443, 27911070557216L, 46, "مرض السكري النوع الثاني", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 444, 25902242271316L, 67, "ارتفاع ضغط الدم", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 1, "Not Dangerous", 1, 2025 },
                    { 445, 29409112072647L, 31, "قصور الغدة الدرقية", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 2, "Not Dangerous", 6, 2025 },
                    { 446, 28703261733539L, 39, "التهاب الأذن الوسطى", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 5, "Not Dangerous", 22, 2025 },
                    { 447, 29508250646133L, 30, "الأنيميا", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 8, "Not Dangerous", 32, 2025 },
                    { 448, 28310150453012L, 42, "آلام الظهر المزمنة", new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 11, "Not Dangerous", 48, 2025 },
                    { 449, 29201091759843L, 34, "النكاف", new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", true, true, false, 2, "Weak", 9, 2025 },
                    { 450, 26405041823548L, 62, "ارتفاع ضغط الدم", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 3, "Not Dangerous", 12, 2025 },
                    { 451, 26505122626923L, 61, "التهاب المسالك البولية", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 452, 26903240593732L, 57, "التهاب المسالك البولية", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 6, "Not Dangerous", 26, 2025 },
                    { 453, 26711271888735L, 58, "الأنيميا", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 454, 28309130411441L, 42, "الملاريا", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", true, true, false, 8, "Medium", 33, 2025 },
                    { 455, 27211090914932L, 53, "التهاب اللوزتين الحاد", new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 3, "Not Dangerous", 13, 2025 },
                    { 456, 25908202772935L, 66, "مرض السكري النوع الثاني", new DateTime(2025, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 10, "Not Dangerous", 41, 2025 },
                    { 457, 29602101223226L, 30, "التهاب المسالك البولية", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 458, 26705112731244L, 59, "الملاريا", new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, true, 5, "Medium", 19, 2025 },
                    { 459, 29205212724525L, 34, "الحموضة وارتجاع المريء", new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 7, "Not Dangerous", 28, 2025 },
                    { 460, 27804052712418L, 48, "الربو القصبي", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 10, "Not Dangerous", 43, 2025 },
                    { 461, 25709052724847L, 68, "التهاب اللوزتين الحاد", new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, true, 10, "Not Dangerous", 44, 2025 },
                    { 462, 28608180783613L, 39, "قصور الغدة الدرقية", new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 5, "Not Dangerous", 21, 2025 },
                    { 463, 26207070450518L, 63, "آلام الظهر المزمنة", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 2, "Not Dangerous", 8, 2025 },
                    { 464, 28310131632728L, 42, "إنفلونزا الطيور", new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", true, true, false, 1, "Strong", 5, 2025 },
                    { 465, 30012182755017L, 25, "الدفتيريا", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, false, 9, "Medium", 40, 2025 },
                    { 466, 25505062460035L, 71, "الحموضة وارتجاع المريء", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 467, 27503110764434L, 51, "الأنيميا", new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 12, "Not Dangerous", 52, 2025 },
                    { 468, 25807092627218L, 67, "التهاب الأذن الوسطى", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 469, 28112070413428L, 44, "ارتفاع ضغط الدم", new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, true, 8, "Not Dangerous", 35, 2025 },
                    { 470, 26810030349019L, 57, "التهاب الجيوب الأنفية", new DateTime(2025, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 9, "Not Dangerous", 36, 2025 },
                    { 471, 29807060933612L, 27, "الصداع النصفي", new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 9, "Not Dangerous", 37, 2025 },
                    { 472, 26311042578026L, 62, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 8, "Not Dangerous", 32, 2025 },
                    { 473, 29211271336524L, 33, "التهاب الجيوب الأنفية", new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 474, 29507171411419L, 30, "التهاب المسالك البولية", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 1, "Not Dangerous", 5, 2025 },
                    { 475, 25604050674431L, 70, "مرض السكري النوع الثاني", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 5, "Not Dangerous", 22, 2025 },
                    { 476, 28108270433316L, 44, "التهاب المفاصل", new DateTime(2025, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 9, "Not Dangerous", 38, 2025 },
                    { 477, 29706231097023L, 28, "الحمى النزفية الفيروسية", new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, true, 11, "Strong", 45, 2025 },
                    { 478, 26911242719819L, 56, "ارتفاع ضغط الدم", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 479, 29602101223226L, 30, "التهاب المسالك البولية", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 480, 26202071747247L, 64, "التهاب الأذن الوسطى", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 5, "Not Dangerous", 19, 2025 },
                    { 481, 28203202548635L, 44, "الربو القصبي", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, true, 2, "Not Dangerous", 7, 2025 },
                    { 482, 27510081922745L, 50, "التسمم الغذائي", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 9, "Weak", 40, 2025 },
                    { 483, 29512171988733L, 30, "الأنيميا", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 2, "Not Dangerous", 9, 2025 },
                    { 484, 26012032527324L, 65, "الحموضة وارتجاع المريء", new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 9, "Not Dangerous", 37, 2025 },
                    { 485, 27303011846934L, 53, "آلام الظهر المزمنة", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 486, 29511200559448L, 30, "التهاب اللوزتين الحاد", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 487, 25805240820423L, 68, "التهاب الأذن الوسطى", new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 5, "Not Dangerous", 19, 2025 },
                    { 488, 25501091671433L, 71, "التهاب المفاصل", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 3, "Not Dangerous", 13, 2025 },
                    { 489, 28708270328423L, 38, "التهاب المعدة والأمعاء", new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 8, "Not Dangerous", 32, 2025 },
                    { 490, 26710060835422L, 58, "الأنيميا", new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, true, 7, "Not Dangerous", 28, 2025 },
                    { 491, 29605262159141L, 30, "آلام الظهر المزمنة", new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 10, "Not Dangerous", 44, 2025 },
                    { 492, 27909242476921L, 46, "الأنيميا", new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 493, 26401090945534L, 62, "الأنيميا", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 494, 27307081432343L, 52, "التهاب المفاصل", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 495, 29911162058212L, 26, "التهاب الجيوب الأنفية", new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 2, "Not Dangerous", 6, 2025 },
                    { 496, 26907131787138L, 56, "التهاب المسالك البولية", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 497, 27707160544839L, 48, "الربو القصبي", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 498, 26004251794235L, 66, "التهاب الجيوب الأنفية", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 499, 26509130297918L, 60, "التهاب اللوزتين الحاد", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 500, 29707182119014L, 28, "التهاب اللوزتين الحاد", new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 7, "Not Dangerous", 29, 2025 },
                    { 501, 27510041789444L, 50, "الجدري المائي", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 3, "Weak", 10, 2025 },
                    { 502, 30509241483728L, 20, "الربو القصبي", new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 503, 26412030877225L, 61, "التهاب المفاصل", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 2, "Not Dangerous", 5, 2025 },
                    { 504, 29703250556636L, 29, "التهاب الجيوب الأنفية", new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 10, "Not Dangerous", 43, 2025 },
                    { 505, 28101151960738L, 45, "الحمى التيفودية", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, true, 5, "Medium", 20, 2025 },
                    { 506, 27206150576843L, 53, "الطاعون", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", true, true, false, 8, "Strong", 33, 2025 },
                    { 507, 29509201483533L, 30, "التهاب المسالك البولية", new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 508, 29704262256412L, 29, "التهاب المسالك البولية", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 509, 30205241280311L, 24, "التهاب المسالك البولية", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 11, "Not Dangerous", 45, 2025 },
                    { 510, 30112210159635L, 24, "آلام الظهر المزمنة", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 2, "Not Dangerous", 8, 2025 },
                    { 511, 28608180783613L, 39, "السعال الديكي", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, true, 1, "Weak", 3, 2025 },
                    { 512, 29602101223226L, 30, "قصور الغدة الدرقية", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 5, "Not Dangerous", 18, 2025 },
                    { 513, 26405060651914L, 62, "الملاريا", new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", true, true, false, 10, "Medium", 44, 2025 },
                    { 514, 26611180563336L, 59, "الربو القصبي", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 515, 27304051311349L, 53, "النكاف", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 3, "Weak", 12, 2025 },
                    { 516, 26310221490217L, 62, "التهاب المسالك البولية", new DateTime(2025, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 9, "Not Dangerous", 37, 2025 },
                    { 517, 29609191652827L, 29, "إنفلونزا الطيور", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, true, 10, "Strong", 42, 2025 },
                    { 518, 28404160791449L, 42, "التهاب الجيوب الأنفية", new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 10, "Not Dangerous", 42, 2025 },
                    { 519, 26007251990146L, 65, "الحمى التيفودية", new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 12, "Medium", 52, 2025 },
                    { 520, 28310131632728L, 42, "التهاب المفاصل", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 3, "Not Dangerous", 12, 2025 },
                    { 521, 30406152649934L, 21, "الطاعون", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, true, 3, "Strong", 12, 2025 },
                    { 522, 30312031681246L, 22, "السل الرئوي", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", true, true, true, 2, "Medium", 9, 2025 },
                    { 523, 26401090871233L, 62, "التهاب المعدة والأمعاء", new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 5, "Not Dangerous", 19, 2025 },
                    { 524, 27511261744633L, 50, "التهاب المعدة والأمعاء", new DateTime(2025, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 11, "Not Dangerous", 44, 2025 },
                    { 525, 25501050850712L, 71, "الكوليرا", new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", true, true, false, 12, "Strong", 50, 2025 },
                    { 526, 25501091671433L, 71, "آلام الظهر المزمنة", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 10, "Not Dangerous", 42, 2025 },
                    { 527, 27210131964727L, 53, "التهاب المسالك البولية", new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 528, 26401090871233L, 62, "الحصبة الألمانية", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", true, true, false, 2, "Medium", 9, 2025 },
                    { 529, 30504281489635L, 21, "الأنيميا", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 530, 27402190215935L, 52, "الطاعون", new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, true, 11, "Strong", 47, 2025 },
                    { 531, 29402151998144L, 32, "مرض السكري النوع الثاني", new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 532, 29609191652827L, 29, "مرض السكري النوع الثاني", new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 2, "Not Dangerous", 9, 2025 },
                    { 533, 27906061966143L, 46, "ارتفاع ضغط الدم", new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 534, 28304140940528L, 43, "قصور الغدة الدرقية", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, true, 1, "Not Dangerous", 3, 2025 },
                    { 535, 29211271336524L, 33, "مرض السكري النوع الثاني", new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 2, "Not Dangerous", 9, 2025 },
                    { 536, 29103232014939L, 35, "التهاب اللوزتين الحاد", new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 537, 27501241555734L, 51, "مرض السكري النوع الثاني", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 2, "Not Dangerous", 6, 2025 },
                    { 538, 29205201930433L, 34, "مرض السكري النوع الثاني", new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 4, "Not Dangerous", 15, 2025 },
                    { 539, 27011140332648L, 55, "التهاب المعدة والأمعاء", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 3, "Not Dangerous", 12, 2025 },
                    { 540, 29903262470515L, 27, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 541, 29208111352836L, 33, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 11, "Not Dangerous", 47, 2025 },
                    { 542, 28310131632728L, 42, "الحموضة وارتجاع المريء", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 4, "Not Dangerous", 14, 2025 },
                    { 543, 29004151684228L, 36, "التهاب المفاصل", new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 544, 26903011925532L, 57, "التهاب المفاصل", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 545, 28102062231211L, 45, "الأنيميا", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 546, 27207010318911L, 53, "الربو القصبي", new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 5, "Not Dangerous", 20, 2025 },
                    { 547, 25908202772935L, 66, "الأنيميا", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 548, 26304081958943L, 63, "الصداع النصفي", new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 10, "Not Dangerous", 43, 2025 },
                    { 549, 28405040354337L, 42, "السل الرئوي", new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, true, 7, "Medium", 28, 2025 },
                    { 550, 30508200661511L, 20, "التهاب اللوزتين الحاد", new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 10, "Not Dangerous", 44, 2025 },
                    { 551, 29707182119014L, 28, "قصور الغدة الدرقية", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 552, 30010101882722L, 25, "التهاب المفاصل", new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 10, "Not Dangerous", 43, 2025 },
                    { 553, 27011140332648L, 55, "الحصبة الألمانية", new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 6, "Medium", 23, 2025 },
                    { 554, 27205221217229L, 54, "التهاب الجيوب الأنفية", new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 555, 25507071264728L, 70, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 5, "Not Dangerous", 19, 2025 },
                    { 556, 27104262140444L, 55, "الربو القصبي", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 3, "Not Dangerous", 12, 2025 },
                    { 557, 27505062553044L, 51, "الأنيميا", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 558, 25612030876039L, 69, "النكاف", new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, true, true, 4, "Weak", 15, 2025 },
                    { 559, 27511240884043L, 50, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 4, "Not Dangerous", 14, 2025 },
                    { 560, 27510041789444L, 50, "آلام الظهر المزمنة", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 10, "Not Dangerous", 40, 2025 },
                    { 561, 28910080232534L, 36, "التهاب الكبد A", new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", true, true, false, 9, "Medium", 40, 2025 },
                    { 562, 26304081958943L, 63, "التهاب المسالك البولية", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 6, "Not Dangerous", 25, 2025 },
                    { 563, 29405131845932L, 32, "التهاب المفاصل", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 8, "Not Dangerous", 32, 2025 },
                    { 564, 25606111335012L, 69, "التهاب اللوزتين الحاد", new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 10, "Not Dangerous", 44, 2025 },
                    { 565, 30402041591623L, 22, "التهاب المسالك البولية", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 8, "Not Dangerous", 33, 2025 },
                    { 566, 29204201910821L, 34, "الحمى التيفودية", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 1, "Medium", 3, 2025 },
                    { 567, 26509130297918L, 60, "الحموضة وارتجاع المريء", new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 568, 28303242043947L, 43, "التهاب اللوزتين الحاد", new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 12, "Not Dangerous", 50, 2025 },
                    { 569, 29301211810425L, 33, "التهاب اللوزتين الحاد", new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, true, 7, "Not Dangerous", 29, 2025 },
                    { 570, 28309012086142L, 42, "التهاب الأذن الوسطى", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, true, 9, "Not Dangerous", 37, 2025 },
                    { 571, 26404161084839L, 62, "الصداع النصفي", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 8, "Not Dangerous", 32, 2025 },
                    { 572, 28410112142732L, 41, "التهاب المفاصل", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 573, 25911222551648L, 66, "الصداع النصفي", new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 4, "Not Dangerous", 15, 2025 },
                    { 574, 26504110427215L, 61, "الكوليرا", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 5, "Strong", 18, 2025 },
                    { 575, 27207010318911L, 53, "الحمى النزفية الفيروسية", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, true, 8, "Strong", 32, 2025 },
                    { 576, 26609101969639L, 59, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 1, "Not Dangerous", 5, 2025 },
                    { 577, 28910080232534L, 36, "التهاب الأذن الوسطى", new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 10, "Not Dangerous", 44, 2025 },
                    { 578, 30205241280311L, 24, "قصور الغدة الدرقية", new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 579, 27503110764434L, 51, "الأنيميا", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 5, "Not Dangerous", 20, 2025 },
                    { 580, 28405040354337L, 42, "التهاب المسالك البولية", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 6, "Not Dangerous", 24, 2025 },
                    { 581, 26901220186821L, 57, "ارتفاع ضغط الدم", new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, true, 2, "Not Dangerous", 9, 2025 },
                    { 582, 27511240884043L, 50, "الطاعون", new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 3, "Strong", 13, 2025 },
                    { 583, 27306201560027L, 52, "مرض السكري النوع الثاني", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 584, 25505062460035L, 71, "الأنيميا", new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 10, "Not Dangerous", 42, 2025 },
                    { 585, 26710050560525L, 58, "التهاب المسالك البولية", new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, true, 7, "Not Dangerous", 30, 2025 },
                    { 586, 25504242411534L, 71, "الصداع النصفي", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 2, "Not Dangerous", 6, 2025 },
                    { 587, 26906010390035L, 57, "التهاب اللوزتين الحاد", new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 10, "Not Dangerous", 44, 2025 },
                    { 588, 29805050237031L, 28, "الحمى الصفراء", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, false, 1, "Strong", 4, 2025 },
                    { 589, 26102161683017L, 65, "السل الرئوي", new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, true, 9, "Medium", 39, 2025 },
                    { 590, 26611180563336L, 59, "مرض السكري النوع الثاني", new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 4, "Not Dangerous", 17, 2025 },
                    { 591, 27812230127946L, 47, "التهاب المسالك البولية", new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 7, "Not Dangerous", 27, 2025 },
                    { 592, 27902182124842L, 47, "مرض السكري النوع الثاني", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 593, 29605240851446L, 30, "الدفتيريا", new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", true, true, true, 7, "Medium", 31, 2025 },
                    { 594, 26206160149046L, 63, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 595, 29605262159141L, 30, "التهاب المسالك البولية", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 596, 27509110737632L, 50, "الجمرة الخبيثة", new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 6, "Strong", 26, 2025 },
                    { 597, 29001230483217L, 36, "التهاب المسالك البولية", new DateTime(2025, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 598, 29502030963945L, 31, "قصور الغدة الدرقية", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 599, 26911231450414L, 56, "التهاب المعدة والأمعاء", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 10, "Not Dangerous", 40, 2025 },
                    { 600, 28108270433316L, 44, "التهاب المفاصل", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 8, "Not Dangerous", 33, 2025 },
                    { 601, 29907062759043L, 26, "الحموضة وارتجاع المريء", new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 4, "Not Dangerous", 16, 2025 },
                    { 602, 27505141187023L, 51, "آلام الظهر المزمنة", new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 10, "Not Dangerous", 40, 2025 },
                    { 603, 26310240723715L, 62, "التهاب المعدة والأمعاء", new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 12, "Not Dangerous", 51, 2025 },
                    { 604, 26304081958943L, 63, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 11, "Not Dangerous", 46, 2025 },
                    { 605, 25501032488425L, 71, "التهاب الجيوب الأنفية", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 4, "Not Dangerous", 15, 2025 },
                    { 606, 28201110715133L, 44, "التهاب الأذن الوسطى", new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 4, "Not Dangerous", 16, 2025 },
                    { 607, 26204021610825L, 64, "ارتفاع ضغط الدم", new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 7, "Not Dangerous", 30, 2025 },
                    { 608, 26303212559348L, 63, "التهاب الأذن الوسطى", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 2, "Not Dangerous", 7, 2025 },
                    { 609, 26311042578026L, 62, "التهاب المفاصل", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 610, 26110011015343L, 64, "آلام الظهر المزمنة", new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 611, 29305112434533L, 33, "الأنيميا", new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 5, "Not Dangerous", 20, 2025 },
                    { 612, 26906010390035L, 57, "قصور الغدة الدرقية", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 1, "Not Dangerous", 3, 2025 },
                    { 613, 30502011419048L, 21, "الدفتيريا", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 5, "Medium", 20, 2025 },
                    { 614, 28109140485342L, 44, "السعال الديكي", new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", true, true, true, 2, "Weak", 9, 2025 },
                    { 615, 27010030881513L, 55, "التهاب المسالك البولية", new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 7, "Not Dangerous", 27, 2025 },
                    { 616, 28211182366018L, 43, "الصداع النصفي", new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 5, "Not Dangerous", 19, 2025 },
                    { 617, 28010032251413L, 45, "التهاب المسالك البولية", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 618, 27605182799835L, 50, "التهاب اللوزتين الحاد", new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 619, 27812022235017L, 47, "التهاب المعدة والأمعاء", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 1, "Not Dangerous", 1, 2025 },
                    { 620, 26007120337426L, 65, "التهاب المسالك البولية", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 621, 25608151831317L, 69, "الصداع النصفي", new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 4, "Not Dangerous", 17, 2025 },
                    { 622, 26101131243314L, 65, "الطاعون", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", true, true, false, 12, "Strong", 49, 2025 },
                    { 623, 27612260840312L, 49, "الدفتيريا", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, false, 12, "Medium", 50, 2025 },
                    { 624, 26501251163248L, 61, "التهاب المسالك البولية", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 6, "Not Dangerous", 24, 2025 },
                    { 625, 28810260432426L, 37, "الطاعون", new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", true, true, false, 5, "Strong", 20, 2025 },
                    { 626, 26505122626923L, 61, "آلام الظهر المزمنة", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 7, "Not Dangerous", 27, 2025 },
                    { 627, 25705061032833L, 69, "التهاب المسالك البولية", new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 7, "Not Dangerous", 31, 2025 },
                    { 628, 29604192279134L, 30, "الحمى التيفودية", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, true, false, 1, "Medium", 3, 2025 },
                    { 629, 29907180467736L, 26, "التهاب المسالك البولية", new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 12, "Not Dangerous", 50, 2025 },
                    { 630, 27411052118146L, 51, "الربو القصبي", new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 4, "Not Dangerous", 17, 2025 },
                    { 631, 28409091494121L, 41, "ارتفاع ضغط الدم", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 632, 25509120344219L, 70, "الملاريا", new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, false, 7, "Medium", 31, 2025 },
                    { 633, 29906031231545L, 27, "الحموضة وارتجاع المريء", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 11, "Not Dangerous", 48, 2025 },
                    { 634, 26810030349019L, 57, "قصور الغدة الدرقية", new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 635, 28304140940528L, 43, "التهاب المعدة والأمعاء", new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, true, 10, "Not Dangerous", 43, 2025 },
                    { 636, 28907162425713L, 36, "ارتفاع ضغط الدم", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 5, "Not Dangerous", 20, 2025 },
                    { 637, 26106170545821L, 64, "التهاب الجيوب الأنفية", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 3, "Not Dangerous", 13, 2025 },
                    { 638, 28805221769315L, 38, "قصور الغدة الدرقية", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 639, 29208011553646L, 33, "الربو القصبي", new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 3, "Not Dangerous", 13, 2025 },
                    { 640, 26911231450414L, 56, "ارتفاع ضغط الدم", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 1, "Not Dangerous", 1, 2025 },
                    { 641, 28507011226947L, 40, "الصداع النصفي", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 8, "Not Dangerous", 34, 2025 },
                    { 642, 26505122626923L, 61, "ارتفاع ضغط الدم", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 643, 25707260961746L, 68, "قصور الغدة الدرقية", new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 7, "Not Dangerous", 29, 2025 },
                    { 644, 28907181573718L, 36, "التهاب المسالك البولية", new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 645, 26210182474616L, 63, "ارتفاع ضغط الدم", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 646, 27905010710646L, 47, "قصور الغدة الدرقية", new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 4, "Not Dangerous", 16, 2025 },
                    { 647, 29710152380223L, 28, "الصداع النصفي", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 648, 27211090914932L, 53, "التهاب المسالك البولية", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 1, "Not Dangerous", 1, 2025 },
                    { 649, 28406122061644L, 41, "الحمى التيفودية", new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", true, true, false, 12, "Medium", 51, 2025 },
                    { 650, 27611162373234L, 49, "قصور الغدة الدرقية", new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 5, "Not Dangerous", 19, 2025 },
                    { 651, 29607110985423L, 29, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 652, 29901190376634L, 27, "ارتفاع ضغط الدم", new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 5, "Not Dangerous", 19, 2025 },
                    { 653, 27506181320721L, 50, "التهاب الجيوب الأنفية", new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, true, 4, "Not Dangerous", 18, 2025 },
                    { 654, 29507060598135L, 30, "آلام الظهر المزمنة", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 3, "Not Dangerous", 11, 2025 },
                    { 655, 25501131084424L, 71, "آلام الظهر المزمنة", new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 656, 27708250891123L, 48, "مرض السكري النوع الثاني", new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 4, "Not Dangerous", 18, 2025 },
                    { 657, 27605182799835L, 50, "التهاب الأذن الوسطى", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 658, 27310072633431L, 52, "الحموضة وارتجاع المريء", new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 659, 26909112682924L, 56, "التهاب الكبد B", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", true, true, false, 8, "Medium", 33, 2025 },
                    { 660, 29208011553646L, 33, "التهاب الكبد C", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, false, 1, "Medium", 2, 2025 },
                    { 661, 28108010320734L, 44, "ارتفاع ضغط الدم", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 6, "Not Dangerous", 25, 2025 },
                    { 662, 28410112142732L, 41, "التهاب الأذن الوسطى", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 663, 28507011226947L, 40, "الحمى الصفراء", new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 9, "Strong", 39, 2025 },
                    { 664, 26105142352636L, 65, "التهاب المفاصل", new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 665, 28707022693816L, 38, "الملاريا", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, true, 6, "Medium", 24, 2025 },
                    { 666, 28111090662438L, 44, "الحموضة وارتجاع المريء", new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 667, 27011140332648L, 55, "آلام الظهر المزمنة", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 668, 26812252287219L, 57, "التهاب الجيوب الأنفية", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 5, "Not Dangerous", 22, 2025 },
                    { 669, 28405040354337L, 42, "الصداع النصفي", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 6, "Not Dangerous", 25, 2025 },
                    { 670, 27308250354835L, 52, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 5, "Not Dangerous", 19, 2025 },
                    { 671, 28708270328423L, 38, "ارتفاع ضغط الدم", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 672, 29507060598135L, 30, "التهاب الكبد C", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, true, 3, "Medium", 14, 2025 },
                    { 673, 29206131525244L, 33, "الصداع النصفي", new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 674, 29606140660042L, 29, "ارتفاع ضغط الدم", new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 12, "Not Dangerous", 49, 2025 },
                    { 675, 26505122626923L, 61, "ارتفاع ضغط الدم", new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 12, "Not Dangerous", 49, 2025 },
                    { 676, 25904101989836L, 67, "الحموضة وارتجاع المريء", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 1, "Not Dangerous", 4, 2025 },
                    { 677, 29705131626346L, 29, "التهاب المعدة والأمعاء", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 678, 25501050850712L, 71, "التهاب الأذن الوسطى", new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 10, "Not Dangerous", 40, 2025 },
                    { 679, 27710080619122L, 48, "السعال الديكي", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, true, 1, "Weak", 3, 2025 },
                    { 680, 29309181152935L, 32, "الدفتيريا", new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 12, "Medium", 52, 2025 },
                    { 681, 29507060598135L, 30, "الحموضة وارتجاع المريء", new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 6, "Not Dangerous", 23, 2025 },
                    { 682, 28409250963939L, 41, "التهاب الكبد A", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, false, 8, "Medium", 34, 2025 },
                    { 683, 28608180783613L, 39, "الحمى النزفية الفيروسية", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, true, 9, "Strong", 38, 2025 },
                    { 684, 28406122061644L, 41, "الأنيميا", new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 685, 29907180467736L, 26, "قصور الغدة الدرقية", new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 10, "Not Dangerous", 43, 2025 },
                    { 686, 29701151597241L, 29, "التهاب اللوزتين الحاد", new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 5, "Not Dangerous", 19, 2025 },
                    { 687, 26204021610825L, 64, "الأنيميا", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 12, "Not Dangerous", 49, 2025 },
                    { 688, 25706241388934L, 68, "الأنيميا", new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 3, "Not Dangerous", 12, 2025 },
                    { 689, 25606111335012L, 69, "ارتفاع ضغط الدم", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 3, "Not Dangerous", 12, 2025 },
                    { 690, 29408171411944L, 31, "قصور الغدة الدرقية", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 12, "Not Dangerous", 50, 2025 },
                    { 691, 29205150754615L, 34, "الحموضة وارتجاع المريء", new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 11, "Not Dangerous", 45, 2025 },
                    { 692, 29907260215819L, 26, "التهاب المعدة والأمعاء", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 693, 26304081958943L, 63, "التهاب المفاصل", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 6, "Not Dangerous", 25, 2025 },
                    { 694, 30210112797917L, 23, "آلام الظهر المزمنة", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 2, "Not Dangerous", 7, 2025 },
                    { 695, 29203081458321L, 34, "آلام الظهر المزمنة", new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 10, "Not Dangerous", 43, 2025 },
                    { 696, 27509110737632L, 50, "آلام الظهر المزمنة", new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 697, 25702021327917L, 69, "الربو القصبي", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 10, "Not Dangerous", 40, 2025 },
                    { 698, 26404161084839L, 62, "الحمى النزفية الفيروسية", new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, false, 5, "Strong", 20, 2025 },
                    { 699, 26403050919049L, 62, "الصداع النصفي", new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 10, "Not Dangerous", 41, 2025 },
                    { 700, 27105110133048L, 55, "مرض السكري النوع الثاني", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 8, "Not Dangerous", 34, 2025 },
                    { 701, 25904102727424L, 67, "التهاب المفاصل", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 11, "Not Dangerous", 48, 2025 },
                    { 702, 27804212623131L, 48, "التهاب المفاصل", new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 5, "Not Dangerous", 21, 2025 },
                    { 703, 28904251435344L, 37, "آلام الظهر المزمنة", new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 2, "Not Dangerous", 9, 2025 },
                    { 704, 27008262663545L, 55, "الطاعون", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, true, 7, "Strong", 30, 2025 },
                    { 705, 27509110737632L, 50, "التهاب المعدة والأمعاء", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 4, "Not Dangerous", 14, 2025 },
                    { 706, 28103171378429L, 45, "الأنيميا", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 8, "Not Dangerous", 33, 2025 },
                    { 707, 29804132016226L, 28, "التهاب اللوزتين الحاد", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 2, "Not Dangerous", 9, 2025 },
                    { 708, 27708250891123L, 48, "الربو القصبي", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 1, "Not Dangerous", 1, 2025 },
                    { 709, 27111250166317L, 54, "الجمرة الخبيثة", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, true, true, 9, "Strong", 40, 2025 },
                    { 710, 27506072316524L, 50, "قصور الغدة الدرقية", new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 711, 26812252287219L, 57, "التهاب المسالك البولية", new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 11, "Not Dangerous", 48, 2025 },
                    { 712, 25601190374917L, 70, "الربو القصبي", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 713, 25806130934535L, 67, "قصور الغدة الدرقية", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 714, 28712041974029L, 38, "الربو القصبي", new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 715, 25504242411534L, 71, "التهاب الأذن الوسطى", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 1, "Not Dangerous", 1, 2025 },
                    { 716, 29802202443343L, 28, "الأنيميا", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 717, 26403050919049L, 62, "السعال الديكي", new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", true, true, false, 12, "Weak", 52, 2025 },
                    { 718, 26705181427449L, 59, "التهاب الكبد C", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, false, 1, "Medium", 2, 2025 },
                    { 719, 27809150890235L, 47, "مرض السكري النوع الثاني", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 720, 29205121611912L, 34, "السعال الديكي", new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, true, 12, "Weak", 50, 2025 },
                    { 721, 29304071192438L, 33, "الصداع النصفي", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 722, 26311211430532L, 62, "التهاب المسالك البولية", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 6, "Not Dangerous", 24, 2025 },
                    { 723, 26208260666922L, 63, "قصور الغدة الدرقية", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 724, 26712040942519L, 58, "الجمرة الخبيثة", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", true, true, false, 3, "Strong", 11, 2025 },
                    { 725, 27807060786621L, 47, "التهاب الأذن الوسطى", new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 8, "Not Dangerous", 32, 2025 },
                    { 726, 29309181152935L, 32, "التهاب الكبد B", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 10, "Medium", 43, 2025 },
                    { 727, 30012250353849L, 25, "قصور الغدة الدرقية", new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 4, "Not Dangerous", 15, 2025 },
                    { 728, 27905010710646L, 47, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 2, "Not Dangerous", 6, 2025 },
                    { 729, 25708162151535L, 68, "التهاب المفاصل", new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 2, "Not Dangerous", 9, 2025 },
                    { 730, 29911261271836L, 26, "التهاب الأذن الوسطى", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 1, "Not Dangerous", 5, 2025 },
                    { 731, 25910271883016L, 66, "الكوليرا", new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", true, true, false, 7, "Strong", 30, 2025 },
                    { 732, 25912080397728L, 66, "التهاب المفاصل", new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 733, 27402190215935L, 52, "آلام الظهر المزمنة", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 12, "Not Dangerous", 50, 2025 },
                    { 734, 27506072316524L, 50, "التهاب الأذن الوسطى", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 8, "Not Dangerous", 34, 2025 },
                    { 735, 26007120337426L, 65, "الكوليرا", new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 12, "Strong", 51, 2025 },
                    { 736, 26403142639441L, 62, "الربو القصبي", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 737, 27304051311349L, 53, "التهاب المعدة والأمعاء", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 738, 25906261624719L, 66, "التهاب الجيوب الأنفية", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 739, 28810112499039L, 37, "الجمرة الخبيثة", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", true, true, false, 1, "Strong", 5, 2025 },
                    { 740, 28801100412539L, 38, "التهاب الأذن الوسطى", new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, true, 10, "Not Dangerous", 42, 2025 },
                    { 741, 27108110599828L, 54, "التهاب المعدة والأمعاء", new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, true, 11, "Not Dangerous", 46, 2025 },
                    { 742, 29304222143823L, 33, "التهاب اللوزتين الحاد", new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 10, "Not Dangerous", 44, 2025 },
                    { 743, 26911102765112L, 56, "آلام الظهر المزمنة", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 5, "Not Dangerous", 21, 2025 },
                    { 744, 27609081887333L, 49, "التهاب المعدة والأمعاء", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 1, "Not Dangerous", 1, 2025 },
                    { 745, 26203240982543L, 64, "التهاب المعدة والأمعاء", new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 746, 27312052010538L, 52, "التهاب المسالك البولية", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 747, 28305082247721L, 43, "التهاب اللوزتين الحاد", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 9, "Not Dangerous", 37, 2025 },
                    { 748, 26405060651914L, 62, "الربو القصبي", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 749, 25509120344219L, 70, "التهاب المعدة والأمعاء", new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 750, 27807170354432L, 47, "الربو القصبي", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 751, 29411140287447L, 31, "السل الرئوي", new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", true, true, false, 5, "Medium", 22, 2025 },
                    { 752, 28903280265834L, 37, "آلام الظهر المزمنة", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 1, "Not Dangerous", 3, 2025 },
                    { 753, 27106162792029L, 54, "الحصبة", new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", true, true, false, 4, "Medium", 18, 2025 },
                    { 754, 26209250732445L, 63, "الحموضة وارتجاع المريء", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 8, "Not Dangerous", 32, 2025 },
                    { 755, 28312052272832L, 42, "الصداع النصفي", new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 12, "Not Dangerous", 49, 2025 },
                    { 756, 25501050850712L, 71, "التهاب الجيوب الأنفية", new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 11, "Not Dangerous", 45, 2025 },
                    { 757, 29211271336524L, 33, "الحمى النزفية الفيروسية", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 7, "Strong", 27, 2025 },
                    { 758, 29707182119014L, 28, "قصور الغدة الدرقية", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 759, 26104061447744L, 65, "التهاب المسالك البولية", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 760, 29409112072647L, 31, "الحمى النزفية الفيروسية", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", true, true, false, 12, "Strong", 50, 2025 },
                    { 761, 27205221217229L, 54, "ارتفاع ضغط الدم", new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 762, 25601190374917L, 70, "الربو القصبي", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 7, "Not Dangerous", 27, 2025 },
                    { 763, 29402051031646L, 32, "التهاب اللوزتين الحاد", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 1, "Not Dangerous", 1, 2025 },
                    { 764, 25509120344219L, 70, "النكاف", new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, false, 4, "Weak", 17, 2025 },
                    { 765, 29511200559448L, 30, "الحموضة وارتجاع المريء", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 6, "Not Dangerous", 23, 2025 },
                    { 766, 26303212559348L, 63, "التهاب اللوزتين الحاد", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 3, "Not Dangerous", 13, 2025 },
                    { 767, 29208111352836L, 33, "ارتفاع ضغط الدم", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 9, "Not Dangerous", 38, 2025 },
                    { 768, 27301211520721L, 53, "إنفلونزا الطيور", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", true, true, false, 6, "Strong", 26, 2025 },
                    { 769, 27209080313425L, 53, "قصور الغدة الدرقية", new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, true, 5, "Not Dangerous", 22, 2025 },
                    { 770, 28312052272832L, 42, "مرض السكري النوع الثاني", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 3, "Not Dangerous", 10, 2025 },
                    { 771, 27306201560027L, 52, "التهاب الكبد B", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", true, true, false, 3, "Medium", 13, 2025 },
                    { 772, 28310131632728L, 42, "الربو القصبي", new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 9, "Not Dangerous", 37, 2025 },
                    { 773, 30207202760829L, 23, "الربو القصبي", new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 4, "Not Dangerous", 17, 2025 },
                    { 774, 26505122626923L, 61, "ارتفاع ضغط الدم", new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 5, "Not Dangerous", 19, 2025 },
                    { 775, 25501050850712L, 71, "التهاب الجيوب الأنفية", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 776, 30207202760829L, 23, "حمى الضنك", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", true, true, false, 8, "Medium", 33, 2025 },
                    { 777, 26509160450543L, 60, "التهاب الكبد C", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, true, 3, "Medium", 11, 2025 },
                    { 778, 30512111954233L, 20, "ارتفاع ضغط الدم", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 8, "Not Dangerous", 34, 2025 },
                    { 779, 25904101989836L, 67, "التهاب المفاصل", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 9, "Not Dangerous", 39, 2025 },
                    { 780, 29605262159141L, 30, "التهاب الكبد C", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 6, "Medium", 24, 2025 },
                    { 781, 29705131626346L, 29, "الأنيميا", new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 5, "Not Dangerous", 22, 2025 },
                    { 782, 28309130411441L, 42, "التهاب المفاصل", new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 783, 28805101046625L, 38, "الأنيميا", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 784, 27403050139245L, 52, "الحموضة وارتجاع المريء", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 10, "Not Dangerous", 40, 2025 },
                    { 785, 28103171378429L, 45, "التهاب الجيوب الأنفية", new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 7, "Not Dangerous", 30, 2025 },
                    { 786, 29110192631047L, 34, "التهاب المعدة والأمعاء", new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 11, "Not Dangerous", 45, 2025 },
                    { 787, 27611162373234L, 49, "التهاب المعدة والأمعاء", new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 10, "Not Dangerous", 42, 2025 },
                    { 788, 25708162151535L, 68, "التهاب الكبد A", new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 7, "Medium", 30, 2025 },
                    { 789, 26802022578942L, 58, "التهاب اللوزتين الحاد", new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 7, "Not Dangerous", 28, 2025 },
                    { 790, 27211090568942L, 53, "الجدري المائي", new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, true, 12, "Weak", 51, 2025 },
                    { 791, 28406122061644L, 41, "التهاب اللوزتين الحاد", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 792, 27603032453425L, 50, "الحمى النزفية الفيروسية", new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, true, 7, "Strong", 31, 2025 },
                    { 793, 29004121325013L, 36, "الحمى الصفراء", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", true, true, false, 3, "Strong", 13, 2025 },
                    { 794, 26507262312143L, 60, "التهاب اللوزتين الحاد", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 2, "Not Dangerous", 8, 2025 },
                    { 795, 29502011495033L, 31, "الربو القصبي", new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, true, 6, "Not Dangerous", 26, 2025 },
                    { 796, 27301211520721L, 53, "التهاب الأذن الوسطى", new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 797, 25911011421642L, 66, "التهاب المعدة والأمعاء", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 2, "Not Dangerous", 8, 2025 },
                    { 798, 27603032453425L, 50, "التهاب الجيوب الأنفية", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 11, "Not Dangerous", 47, 2025 },
                    { 799, 27909242476921L, 46, "الحمى النزفية الفيروسية", new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", true, true, false, 7, "Strong", 30, 2025 },
                    { 800, 27505141187023L, 51, "التهاب المعدة والأمعاء", new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 4, "Not Dangerous", 18, 2025 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 301, 27908091222948L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 302, 26902091750426L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 303, 26301141133025L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 304, 26504110427215L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 305, 28010032251413L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 306, 28108270433316L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 307, 27306201560027L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 308, 26512100991915L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 309, 26703070444031L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 310, 29412240719842L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 311, 27207010318911L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 312, 26711271888735L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 313, 27909242476921L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 314, 26509160450543L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 315, 26509160450543L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 316, 28810260432426L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 317, 29208011553646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 318, 25707260961746L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 319, 27609081887333L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 320, 29204201910821L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 321, 27403050139245L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 322, 27612260840312L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 323, 29707182119014L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 324, 29004121325013L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 325, 29606140660042L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 326, 29507060598135L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 327, 29502011495033L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 328, 28406122061644L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 329, 26401090945534L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 330, 27211090568942L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 331, 28109192219726L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 332, 28304140940528L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 333, 26601172079928L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 334, 29602061327126L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 335, 30312031681246L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 336, 26004251794235L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 337, 26601230933711L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 338, 27206150576843L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 339, 25504242411534L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 340, 28608180783613L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 341, 28111090662438L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 342, 25805240820423L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 343, 30207202760829L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 344, 28111090662438L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 345, 26012032527324L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 346, 28908152583844L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 347, 27909242476921L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 348, 29609162011614L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 349, 30512242187043L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 350, 27110191267934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 351, 27402270257328L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 352, 26102161683017L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 353, 26311211430532L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 354, 26210200423442L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 355, 29902021581915L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 356, 25501091671433L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 357, 30402041591623L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 358, 25911201723239L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 359, 27111250166317L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 360, 28506221177223L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 361, 29502200562115L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 362, 27011140332648L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 363, 28101061646726L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 364, 27611162373234L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 365, 28409091494121L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 366, 29104112764219L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 367, 28409091494121L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 368, 27301211520721L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 369, 30502011419048L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 370, 29602101223226L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 371, 28910080232534L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 372, 28312052272832L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 373, 27807060786621L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 374, 26311042578026L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 375, 26710050560525L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 376, 29609181438041L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 377, 28310131632728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 378, 29412240719842L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 379, 28101061646726L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 380, 27109132788216L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 381, 28408161691518L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 382, 26307020364649L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 383, 29906031231545L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 384, 29208011553646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 385, 28111090662438L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 386, 26304081958943L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 387, 29609162011614L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 388, 25906261624719L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 389, 29508250646133L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 390, 27402270257328L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 391, 30203062369321L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 392, 27501121188627L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 393, 27511261744633L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 394, 27206150576843L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 395, 28606280831448L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 396, 26011271939936L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 397, 27412110150319L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 398, 25804031762917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 399, 29902021581915L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 400, 26909112682924L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 401, 26906132195932L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 402, 30412130970331L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 403, 26305201632248L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 404, 26007120337426L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 405, 26509130297918L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 406, 28404172440533L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 407, 30406152649934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 408, 29508250646133L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 409, 29805050237031L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 410, 26812252287219L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 411, 27710080619122L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 412, 29203081458321L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 413, 29009180595917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 414, 29102280933313L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 415, 27403240425049L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 416, 26512160881922L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 417, 29402051031646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 418, 28209230772216L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 419, 27206150576843L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 420, 30404280672735L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 421, 26606160353115L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 422, 28412052161645L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 423, 29409112072647L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 424, 29610040117014L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 425, 29304071787113L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 426, 28409250963939L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 427, 29211271336524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 428, 30311020977349L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 429, 27511261744633L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 430, 26105142352636L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 431, 29105160449241L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 432, 28910080232534L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 433, 29009180595917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 434, 29604192279134L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 435, 29211271336524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 436, 30502011419048L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 437, 27403240425049L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 438, 29707140611316L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 439, 28109192219726L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 440, 29410222120936L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 441, 26512100991915L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 442, 28103212755522L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 443, 27911070557216L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 444, 25902242271316L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 445, 29409112072647L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 446, 28703261733539L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 447, 29508250646133L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 448, 28310150453012L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 449, 29201091759843L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 450, 26405041823548L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 451, 26505122626923L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 452, 26903240593732L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 453, 26711271888735L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 454, 28309130411441L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 455, 27211090914932L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 456, 25908202772935L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 457, 29602101223226L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 458, 26705112731244L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 459, 29205212724525L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 460, 27804052712418L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 461, 25709052724847L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 462, 28608180783613L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 463, 26207070450518L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 464, 28310131632728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 465, 30012182755017L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 466, 25505062460035L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 467, 27503110764434L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 468, 25807092627218L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 469, 28112070413428L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 470, 26810030349019L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 471, 29807060933612L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 472, 26311042578026L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 473, 29211271336524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 474, 29507171411419L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 475, 25604050674431L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 476, 28108270433316L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 477, 29706231097023L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 478, 26911242719819L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 479, 29602101223226L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 480, 26202071747247L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 481, 28203202548635L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 482, 27510081922745L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 483, 29512171988733L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 484, 26012032527324L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 485, 27303011846934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 486, 29511200559448L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 487, 25805240820423L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 488, 25501091671433L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 489, 28708270328423L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 490, 26710060835422L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 491, 29605262159141L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 492, 27909242476921L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 493, 26401090945534L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 494, 27307081432343L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 495, 29911162058212L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 496, 26907131787138L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 497, 27707160544839L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 498, 26004251794235L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 499, 26509130297918L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 500, 29707182119014L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 501, 27510041789444L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 502, 30509241483728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 503, 26412030877225L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 504, 29703250556636L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 505, 28101151960738L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 506, 27206150576843L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 507, 29509201483533L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 508, 29704262256412L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 509, 30205241280311L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 510, 30112210159635L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 511, 28608180783613L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 512, 29602101223226L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 513, 26405060651914L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 514, 26611180563336L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 515, 27304051311349L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 516, 26310221490217L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 517, 29609191652827L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 518, 28404160791449L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 519, 26007251990146L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 520, 28310131632728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 521, 30406152649934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 522, 30312031681246L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 523, 26401090871233L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 524, 27511261744633L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 525, 25501050850712L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 526, 25501091671433L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 527, 27210131964727L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 528, 26401090871233L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 529, 30504281489635L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 530, 27402190215935L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 531, 29402151998144L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 532, 29609191652827L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 533, 27906061966143L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 534, 28304140940528L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 535, 29211271336524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 536, 29103232014939L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 537, 27501241555734L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 538, 29205201930433L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 539, 27011140332648L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 540, 29903262470515L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 541, 29208111352836L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 542, 28310131632728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 543, 29004151684228L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 544, 26903011925532L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 545, 28102062231211L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 546, 27207010318911L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 547, 25908202772935L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 548, 26304081958943L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 549, 28405040354337L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 550, 30508200661511L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 551, 29707182119014L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 552, 30010101882722L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 553, 27011140332648L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 554, 27205221217229L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 555, 25507071264728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 556, 27104262140444L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 557, 27505062553044L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 558, 25612030876039L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 559, 27511240884043L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 560, 27510041789444L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 561, 28910080232534L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 562, 26304081958943L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 563, 29405131845932L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 564, 25606111335012L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 565, 30402041591623L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 566, 29204201910821L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 567, 26509130297918L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 568, 28303242043947L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 569, 29301211810425L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 570, 28309012086142L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 571, 26404161084839L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 572, 28410112142732L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 573, 25911222551648L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 574, 26504110427215L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 575, 27207010318911L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 576, 26609101969639L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 577, 28910080232534L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 578, 30205241280311L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 579, 27503110764434L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 580, 28405040354337L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 581, 26901220186821L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 582, 27511240884043L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 583, 27306201560027L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 584, 25505062460035L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 585, 26710050560525L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 586, 25504242411534L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 587, 26906010390035L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 588, 29805050237031L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 589, 26102161683017L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 590, 26611180563336L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 591, 27812230127946L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 592, 27902182124842L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 593, 29605240851446L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 594, 26206160149046L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 595, 29605262159141L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 596, 27509110737632L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 597, 29001230483217L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 598, 29502030963945L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 599, 26911231450414L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 600, 28108270433316L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 601, 29907062759043L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 602, 27505141187023L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 603, 26310240723715L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 604, 26304081958943L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 605, 25501032488425L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 606, 28201110715133L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 607, 26204021610825L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 608, 26303212559348L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 609, 26311042578026L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 610, 26110011015343L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 611, 29305112434533L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 612, 26906010390035L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 613, 30502011419048L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 614, 28109140485342L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 615, 27010030881513L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 616, 28211182366018L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 617, 28010032251413L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 618, 27605182799835L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 619, 27812022235017L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 620, 26007120337426L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 621, 25608151831317L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 622, 26101131243314L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 623, 27612260840312L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 624, 26501251163248L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 625, 28810260432426L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 626, 26505122626923L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 627, 25705061032833L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 628, 29604192279134L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 629, 29907180467736L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 630, 27411052118146L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 631, 28409091494121L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 632, 25509120344219L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 633, 29906031231545L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 634, 26810030349019L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 635, 28304140940528L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 636, 28907162425713L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 637, 26106170545821L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 638, 28805221769315L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 639, 29208011553646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 640, 26911231450414L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 641, 28507011226947L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 642, 26505122626923L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 643, 25707260961746L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 644, 28907181573718L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 645, 26210182474616L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 646, 27905010710646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 647, 29710152380223L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 648, 27211090914932L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 649, 28406122061644L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 650, 27611162373234L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 651, 29607110985423L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 652, 29901190376634L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 653, 27506181320721L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 654, 29507060598135L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 655, 25501131084424L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 656, 27708250891123L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 657, 27605182799835L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 658, 27310072633431L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 659, 26909112682924L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 660, 29208011553646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 661, 28108010320734L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 662, 28410112142732L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 663, 28507011226947L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 664, 26105142352636L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 665, 28707022693816L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 666, 28111090662438L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 667, 27011140332648L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 668, 26812252287219L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 669, 28405040354337L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 670, 27308250354835L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 671, 28708270328423L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 672, 29507060598135L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 673, 29206131525244L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 674, 29606140660042L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 675, 26505122626923L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 676, 25904101989836L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 677, 29705131626346L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 678, 25501050850712L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 679, 27710080619122L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 680, 29309181152935L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 681, 29507060598135L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 682, 28409250963939L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 683, 28608180783613L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 684, 28406122061644L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 685, 29907180467736L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 686, 29701151597241L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 687, 26204021610825L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 688, 25706241388934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 689, 25606111335012L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 690, 29408171411944L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 691, 29205150754615L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 692, 29907260215819L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 693, 26304081958943L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 694, 30210112797917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 695, 29203081458321L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 696, 27509110737632L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 697, 25702021327917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 698, 26404161084839L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 699, 26403050919049L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 700, 27105110133048L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 701, 25904102727424L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 702, 27804212623131L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 703, 28904251435344L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 704, 27008262663545L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 705, 27509110737632L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 706, 28103171378429L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 707, 29804132016226L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 708, 27708250891123L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 709, 27111250166317L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 710, 27506072316524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 711, 26812252287219L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 712, 25601190374917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 713, 25806130934535L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 714, 28712041974029L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 715, 25504242411534L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 716, 29802202443343L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 717, 26403050919049L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 718, 26705181427449L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 719, 27809150890235L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 720, 29205121611912L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 721, 29304071192438L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 722, 26311211430532L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 723, 26208260666922L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 724, 26712040942519L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 725, 27807060786621L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 726, 29309181152935L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 727, 30012250353849L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 728, 27905010710646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 729, 25708162151535L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 730, 29911261271836L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 731, 25910271883016L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 732, 25912080397728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 733, 27402190215935L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 734, 27506072316524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 735, 26007120337426L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 736, 26403142639441L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 737, 27304051311349L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 738, 25906261624719L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 739, 28810112499039L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 740, 28801100412539L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 741, 27108110599828L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 742, 29304222143823L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 743, 26911102765112L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 744, 27609081887333L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 745, 26203240982543L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 746, 27312052010538L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 747, 28305082247721L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 748, 26405060651914L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 749, 25509120344219L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 750, 27807170354432L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 751, 29411140287447L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 752, 28903280265834L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 753, 27106162792029L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 754, 26209250732445L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 755, 28312052272832L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 756, 25501050850712L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 757, 29211271336524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 758, 29707182119014L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 759, 26104061447744L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 760, 29409112072647L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 761, 27205221217229L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 762, 25601190374917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 763, 29402051031646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 764, 25509120344219L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 765, 29511200559448L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 766, 26303212559348L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 767, 29208111352836L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 768, 27301211520721L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 769, 27209080313425L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 770, 28312052272832L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 771, 27306201560027L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 772, 28310131632728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 773, 30207202760829L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 774, 26505122626923L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 775, 25501050850712L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 776, 30207202760829L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 777, 26509160450543L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 778, 30512111954233L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 779, 25904101989836L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 780, 29605262159141L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 781, 29705131626346L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 782, 28309130411441L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 783, 28805101046625L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 784, 27403050139245L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 785, 28103171378429L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 786, 29110192631047L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 787, 27611162373234L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 788, 25708162151535L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 789, 26802022578942L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 790, 27211090568942L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 791, 28406122061644L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 792, 27603032453425L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 793, 29004121325013L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 794, 26507262312143L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 795, 29502011495033L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 796, 27301211520721L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 797, 25911011421642L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 798, 27603032453425L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 799, 27909242476921L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 800, 27505141187023L });
        }
    }
}
