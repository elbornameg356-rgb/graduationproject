using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutpatientClinicsComplex.Migrations
{
    /// <inheritdoc />
    public partial class datasetdiagnosis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "NationalId", "Age", "Diagnosis", "DiagnosisDate", "DoctorCode", "Gender", "IsDangerous", "IsReported", "LabConfirmed", "Month", "RiskLevel", "WeekNumber", "Year" },
                values: new object[,]
                {
                    { 1, 25905011269245L, 67, "الأنيميا", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 10, "Not Dangerous", 43, 2025 },
                    { 2, 26609101969639L, 59, "الطاعون", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, true, 5, "Strong", 19, 2026 },
                    { 3, 27302092052212L, 53, "الأنيميا", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 1, "Not Dangerous", 1, 2025 },
                    { 4, 27110191267934L, 54, "التهاب الجيوب الأنفية", new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 5, 26911231450414L, 56, "الجمرة الخبيثة", new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, true, 4, "Strong", 16, 2025 },
                    { 6, 26103191967218L, 65, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 7, 28205142294615L, 44, "قصور الغدة الدرقية", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 6, "Not Dangerous", 25, 2025 },
                    { 8, 27904202293424L, 47, "التسمم الغذائي", new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 6, "Weak", 26, 2025 },
                    { 9, 29009180595917L, 35, "ارتفاع ضغط الدم", new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 5, "Not Dangerous", 18, 2025 },
                    { 10, 26102161683017L, 65, "الحموضة وارتجاع المريء", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 3, "Not Dangerous", 13, 2025 },
                    { 11, 29911261271836L, 26, "الصداع النصفي", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 5, "Not Dangerous", 22, 2025 },
                    { 12, 29706262713545L, 28, "التهاب الأذن الوسطى", new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 9, "Not Dangerous", 39, 2025 },
                    { 13, 28203202548635L, 44, "السعال الديكي", new DateTime(2026, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", true, false, true, 6, "Weak", 23, 2026 },
                    { 14, 29711141255012L, 28, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 8, "Not Dangerous", 32, 2025 },
                    { 15, 28201110715133L, 44, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 4, "Not Dangerous", 15, 2025 },
                    { 16, 30406061549427L, 21, "الأنيميا", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 17, 28309012086142L, 42, "الحموضة وارتجاع المريء", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, true, 8, "Not Dangerous", 34, 2025 },
                    { 18, 27905010710646L, 47, "شلل الأطفال", new DateTime(2026, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, false, false, 6, "Strong", 23, 2026 },
                    { 19, 25912210595421L, 66, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 20, 30406152649934L, 21, "آلام الظهر المزمنة", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 11, "Not Dangerous", 46, 2025 },
                    { 21, 29409112072647L, 31, "التهاب الأذن الوسطى", new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 7, "Not Dangerous", 28, 2025 },
                    { 22, 29309181152935L, 32, "آلام الظهر المزمنة", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 10, "Not Dangerous", 40, 2025 },
                    { 23, 26802022578942L, 58, "الربو القصبي", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 12, "Not Dangerous", 50, 2025 },
                    { 24, 25604050674431L, 70, "التهاب المعدة والأمعاء", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 8, "Not Dangerous", 34, 2025 },
                    { 25, 25802082334821L, 68, "الجمرة الخبيثة", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", true, true, false, 11, "Strong", 47, 2025 },
                    { 26, 29710152380223L, 28, "ارتفاع ضغط الدم", new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 10, "Not Dangerous", 44, 2025 },
                    { 27, 26810030349019L, 57, "ارتفاع ضغط الدم", new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 28, 28502111480343L, 41, "التهاب المعدة والأمعاء", new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 29, 27501121188627L, 51, "الربو القصبي", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 1, "Not Dangerous", 5, 2025 },
                    { 30, 27303011846934L, 53, "الأنيميا", new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 12, "Not Dangerous", 50, 2025 },
                    { 31, 28310150453012L, 42, "الملاريا", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 6, "Medium", 23, 2025 },
                    { 32, 28705190974544L, 39, "الكوليرا", new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 8, "Strong", 35, 2025 },
                    { 33, 27710080619122L, 48, "التهاب الجيوب الأنفية", new DateTime(2025, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 9, "Not Dangerous", 38, 2025 },
                    { 34, 28201110715133L, 44, "الربو القصبي", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 35, 29309181152935L, 32, "مرض السكري النوع الثاني", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 36, 26601240218847L, 60, "الجدري المائي", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, true, 12, "Weak", 49, 2025 },
                    { 37, 28109171082233L, 44, "التهاب اللوزتين الحاد", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 9, "Not Dangerous", 37, 2025 },
                    { 38, 25904101989836L, 67, "التهاب اللوزتين الحاد", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 2, "Not Dangerous", 6, 2025 },
                    { 39, 29208011553646L, 33, "التهاب الأذن الوسطى", new DateTime(2025, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 10, "Not Dangerous", 44, 2025 },
                    { 40, 25904012281337L, 67, "التهاب المفاصل", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 41, 26704012644443L, 59, "ارتفاع ضغط الدم", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 11, "Not Dangerous", 48, 2025 },
                    { 42, 25508220421416L, 70, "التهاب الأذن الوسطى", new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 2, "Not Dangerous", 9, 2025 },
                    { 43, 27301211520721L, 53, "الحموضة وارتجاع المريء", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 1, "Not Dangerous", 3, 2025 },
                    { 44, 26310240723715L, 62, "حمى الضنك", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, true, 5, "Medium", 22, 2026 },
                    { 45, 26105142352636L, 65, "التهاب السحايا البكتيري", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 1, "Medium", 4, 2025 },
                    { 46, 27312052010538L, 52, "مرض السكري النوع الثاني", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 10, "Not Dangerous", 43, 2025 },
                    { 47, 29906211729838L, 26, "الأنيميا", new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 12, "Not Dangerous", 50, 2025 },
                    { 48, 28003081867814L, 46, "التهاب المعدة والأمعاء", new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 7, "Not Dangerous", 29, 2025 },
                    { 49, 26104061447744L, 65, "الحصبة الألمانية", new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 12, "Medium", 49, 2025 },
                    { 50, 28404160791449L, 42, "التهاب الأذن الوسطى", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 1, "Not Dangerous", 4, 2025 },
                    { 51, 28302130650018L, 43, "قصور الغدة الدرقية", new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 3, "Not Dangerous", 12, 2025 },
                    { 52, 26903011925532L, 57, "قصور الغدة الدرقية", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 53, 27505141187023L, 51, "مرض السكري النوع الثاني", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 6, "Not Dangerous", 23, 2025 },
                    { 54, 26207070450518L, 63, "الصداع النصفي", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 2, "Not Dangerous", 6, 2025 },
                    { 55, 25609150911841L, 69, "التهاب المفاصل", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 56, 27510041789444L, 50, "مرض السكري النوع الثاني", new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 57, 26604102257635L, 60, "التهاب الكبد C", new DateTime(2026, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, true, 5, "Medium", 19, 2026 },
                    { 58, 29805050237031L, 28, "الحصبة", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, false, 1, "Medium", 1, 2025 },
                    { 59, 27506072316524L, 50, "قصور الغدة الدرقية", new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 60, 26911102765112L, 56, "الحموضة وارتجاع المريء", new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 61, 25706241388934L, 68, "الجدري المائي", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", true, true, false, 1, "Weak", 3, 2025 },
                    { 62, 25911201723239L, 66, "التهاب المعدة والأمعاء", new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 9, "Not Dangerous", 39, 2025 },
                    { 63, 29807060933612L, 27, "الحمى النزفية الفيروسية", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, true, true, 5, "Strong", 22, 2026 },
                    { 64, 26911242719819L, 56, "مرض السكري النوع الثاني", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 10, "Not Dangerous", 41, 2025 },
                    { 65, 27008262663545L, 55, "مرض السكري النوع الثاني", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 8, "Not Dangerous", 34, 2025 },
                    { 66, 29507171411419L, 30, "مرض السكري النوع الثاني", new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 67, 28112070413428L, 44, "التهاب السحايا البكتيري", new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", true, true, true, 3, "Medium", 14, 2025 },
                    { 68, 27501121188627L, 51, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 4, "Not Dangerous", 17, 2025 },
                    { 69, 28102062231211L, 45, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 2, "Not Dangerous", 8, 2025 },
                    { 70, 26512100991915L, 60, "ارتفاع ضغط الدم", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 12, "Not Dangerous", 50, 2025 },
                    { 71, 29105160449241L, 35, "الحمى الصفراء", new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, true, 8, "Strong", 35, 2025 },
                    { 72, 26405041823548L, 62, "التهاب اللوزتين الحاد", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 12, "Not Dangerous", 49, 2025 },
                    { 73, 29706231097023L, 28, "آلام الظهر المزمنة", new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 5, "Not Dangerous", 21, 2025 },
                    { 74, 29606140660042L, 29, "آلام الظهر المزمنة", new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 75, 29609181438041L, 29, "التهاب اللوزتين الحاد", new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 11, "Not Dangerous", 45, 2025 },
                    { 76, 26812252287219L, 57, "قصور الغدة الدرقية", new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 7, "Not Dangerous", 28, 2025 },
                    { 77, 26204021610825L, 64, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 7, "Not Dangerous", 29, 2025 },
                    { 78, 29511200559448L, 30, "التهاب الأذن الوسطى", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 79, 25904012281337L, 67, "التهاب المعدة والأمعاء", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 8, "Not Dangerous", 34, 2025 },
                    { 80, 29711141255012L, 28, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 5, "Not Dangerous", 21, 2025 },
                    { 81, 26809072274323L, 57, "التسمم الغذائي", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 9, "Weak", 39, 2025 },
                    { 82, 26810030349019L, 57, "التهاب الكبد B", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 6, "Medium", 24, 2025 },
                    { 83, 29912142763041L, 26, "التهاب المعدة والأمعاء", new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 84, 27206150576843L, 53, "الصداع النصفي", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 8, "Not Dangerous", 34, 2025 },
                    { 85, 26210200423442L, 63, "التهاب الجيوب الأنفية", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 86, 29210181337133L, 33, "الطاعون", new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", true, true, false, 3, "Strong", 12, 2025 },
                    { 87, 30302121229811L, 23, "الربو القصبي", new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 10, "Not Dangerous", 43, 2025 },
                    { 88, 27807170354432L, 47, "آلام الظهر المزمنة", new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 11, "Not Dangerous", 45, 2025 },
                    { 89, 28310131632728L, 42, "التهاب الجيوب الأنفية", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 9, "Not Dangerous", 37, 2025 },
                    { 90, 28109140485342L, 44, "مرض السكري النوع الثاني", new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 7, "Not Dangerous", 28, 2025 },
                    { 91, 29309181152935L, 32, "التهاب المفاصل", new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 7, "Not Dangerous", 30, 2025 },
                    { 92, 29411140287447L, 31, "الحموضة وارتجاع المريء", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 93, 29602101223226L, 30, "التهاب الأذن الوسطى", new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 12, "Not Dangerous", 50, 2025 },
                    { 94, 29009180595917L, 35, "الكوليرا", new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, false, 2, "Strong", 8, 2025 },
                    { 95, 29004151684228L, 36, "الدفتيريا", new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 2, "Medium", 9, 2025 },
                    { 96, 25707260961746L, 68, "ارتفاع ضغط الدم", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 97, 26712040942519L, 58, "التهاب اللوزتين الحاد", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 98, 26802151998438L, 58, "الأنيميا", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 99, 26803152251546L, 58, "التهاب المفاصل", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 6, "Not Dangerous", 25, 2025 },
                    { 100, 29812011274846L, 27, "ارتفاع ضغط الدم", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 101, 27906020778748L, 47, "التهاب المعدة والأمعاء", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 102, 26512160881922L, 60, "قصور الغدة الدرقية", new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 12, "Not Dangerous", 49, 2025 },
                    { 103, 26110011015343L, 64, "قصور الغدة الدرقية", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 7, "Not Dangerous", 27, 2025 },
                    { 104, 26207070450518L, 63, "الربو القصبي", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 105, 30408110458418L, 21, "الربو القصبي", new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 8, "Not Dangerous", 32, 2025 },
                    { 106, 27010231899225L, 55, "شلل الأطفال", new DateTime(2026, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", true, false, false, 6, "Strong", 23, 2026 },
                    { 107, 26802200544638L, 58, "إنفلونزا الطيور", new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, false, 6, "Strong", 27, 2025 },
                    { 108, 29907180467736L, 26, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 12, "Not Dangerous", 52, 2025 },
                    { 109, 29707182119014L, 28, "التهاب اللوزتين الحاد", new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 110, 29907180467736L, 26, "الحمى الصفراء", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, true, 5, "Strong", 22, 2026 },
                    { 111, 28608180783613L, 39, "التهاب الأذن الوسطى", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 9, "Not Dangerous", 38, 2025 },
                    { 112, 29509201483533L, 30, "الحمى الصفراء", new DateTime(2025, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, false, 11, "Strong", 44, 2025 },
                    { 113, 26404161084839L, 62, "التهاب الكبد A", new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, false, 7, "Medium", 29, 2025 },
                    { 114, 27707162418322L, 48, "مرض السكري النوع الثاني", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 7, "Not Dangerous", 27, 2025 },
                    { 115, 29703250556636L, 29, "الربو القصبي", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 116, 25507071264728L, 70, "التهاب المسالك البولية", new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 11, "Not Dangerous", 48, 2025 },
                    { 117, 29110192631047L, 34, "قصور الغدة الدرقية", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 118, 29709171562135L, 28, "التهاب الأذن الوسطى", new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 12, "Not Dangerous", 52, 2025 },
                    { 119, 28810112499039L, 37, "مرض السكري النوع الثاني", new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 120, 27707162418322L, 48, "التهاب المسالك البولية", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 121, 28208070953031L, 43, "الملاريا", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", true, true, false, 10, "Medium", 41, 2025 },
                    { 122, 26403050919049L, 62, "الربو القصبي", new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 11, "Not Dangerous", 48, 2025 },
                    { 123, 28805101046625L, 38, "التهاب اللوزتين الحاد", new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 124, 27304051311349L, 53, "ارتفاع ضغط الدم", new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 1, "Not Dangerous", 5, 2025 },
                    { 125, 27611162373234L, 49, "الأنيميا", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 3, "Not Dangerous", 9, 2025 },
                    { 126, 26911242719819L, 56, "التهاب اللوزتين الحاد", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 127, 26106170545821L, 64, "إنفلونزا الطيور", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, true, 5, "Strong", 22, 2026 },
                    { 128, 26001251776233L, 66, "الجمرة الخبيثة", new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, false, 2, "Strong", 9, 2025 },
                    { 129, 27506072316524L, 50, "قصور الغدة الدرقية", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 130, 28404172440533L, 42, "الحموضة وارتجاع المريء", new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 7, "Not Dangerous", 29, 2025 },
                    { 131, 27509102343431L, 50, "الطاعون", new DateTime(2025, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, true, false, 9, "Strong", 39, 2025 },
                    { 132, 30210112797917L, 23, "التهاب الجيوب الأنفية", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 1, "Not Dangerous", 3, 2025 },
                    { 133, 29307172516614L, 32, "التهاب الجيوب الأنفية", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 11, "Not Dangerous", 48, 2025 },
                    { 134, 29211271336524L, 33, "قصور الغدة الدرقية", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 135, 29606190935334L, 29, "التهاب المعدة والأمعاء", new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 6, "Not Dangerous", 26, 2025 },
                    { 136, 28109140485342L, 44, "الصداع النصفي", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 3, "Not Dangerous", 13, 2025 },
                    { 137, 26810030349019L, 57, "آلام الظهر المزمنة", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 138, 29704192792019L, 29, "آلام الظهر المزمنة", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 10, "Not Dangerous", 42, 2025 },
                    { 139, 25609150911841L, 69, "آلام الظهر المزمنة", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 140, 27301192714834L, 53, "التهاب الجيوب الأنفية", new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 4, "Not Dangerous", 15, 2025 },
                    { 141, 30111041134926L, 24, "مرض السكري النوع الثاني", new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 11, "Not Dangerous", 45, 2025 },
                    { 142, 26209250732445L, 63, "الصداع النصفي", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 6, "Not Dangerous", 24, 2025 },
                    { 143, 25807092627218L, 67, "التهاب اللوزتين الحاد", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 12, "Not Dangerous", 49, 2025 },
                    { 144, 26603031269339L, 60, "الأنيميا", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 6, "Not Dangerous", 25, 2025 },
                    { 145, 29512171988733L, 30, "الحمى الصفراء", new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, false, 6, "Strong", 23, 2025 },
                    { 146, 26710060835422L, 58, "الحموضة وارتجاع المريء", new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, true, 4, "Not Dangerous", 16, 2025 },
                    { 147, 28908152583844L, 36, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 7, "Not Dangerous", 29, 2025 },
                    { 148, 26103191967218L, 65, "الربو القصبي", new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 2, "Not Dangerous", 8, 2025 },
                    { 149, 26808261599031L, 57, "الأنيميا", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 3, "Not Dangerous", 13, 2025 },
                    { 150, 27302092052212L, 53, "التهاب اللوزتين الحاد", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 1, "Not Dangerous", 1, 2025 },
                    { 151, 29901190376634L, 27, "التهاب المفاصل", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 6, "Not Dangerous", 23, 2025 },
                    { 152, 29903262470515L, 27, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 8, "Not Dangerous", 34, 2025 },
                    { 153, 29401140884613L, 32, "قصور الغدة الدرقية", new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 154, 29609181438041L, 29, "ارتفاع ضغط الدم", new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 155, 25706241388934L, 68, "الأنيميا", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 11, "Not Dangerous", 47, 2025 },
                    { 156, 27403240425049L, 52, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 12, "Not Dangerous", 51, 2025 },
                    { 157, 29502030963945L, 31, "التهاب الأذن الوسطى", new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 2, "Not Dangerous", 9, 2025 },
                    { 158, 27007121572627L, 55, "الربو القصبي", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 2, "Not Dangerous", 8, 2025 },
                    { 159, 28103171378429L, 45, "التهاب المسالك البولية", new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 7, "Not Dangerous", 28, 2025 },
                    { 160, 27807170354432L, 47, "قصور الغدة الدرقية", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 5, "Not Dangerous", 18, 2025 },
                    { 161, 27908091222948L, 46, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 1, "Not Dangerous", 2, 2025 },
                    { 162, 29802202443343L, 28, "الكوليرا", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 10, "Strong", 42, 2025 },
                    { 163, 29906171167018L, 26, "الصداع النصفي", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 11, "Not Dangerous", 46, 2025 },
                    { 164, 26711271888735L, 58, "الجمرة الخبيثة", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", true, true, false, 3, "Strong", 11, 2025 },
                    { 165, 27612260840312L, 49, "التهاب الكبد A", new DateTime(2025, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, false, 9, "Medium", 36, 2025 },
                    { 166, 28404160791449L, 42, "التهاب المفاصل", new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 11, "Not Dangerous", 47, 2025 },
                    { 167, 28710042492533L, 38, "آلام الظهر المزمنة", new DateTime(2025, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 9, "Not Dangerous", 38, 2025 },
                    { 168, 25710272789132L, 68, "التهاب الكبد B", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 11, "Medium", 46, 2025 },
                    { 169, 29205150754615L, 34, "التهاب الجيوب الأنفية", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 2, "Not Dangerous", 6, 2025 },
                    { 170, 28907181573718L, 36, "الجمرة الخبيثة", new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, false, 12, "Strong", 52, 2025 },
                    { 171, 26509160450543L, 60, "التهاب المسالك البولية", new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 4, "Not Dangerous", 16, 2025 },
                    { 172, 26911231450414L, 56, "الحصبة", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, true, 3, "Medium", 13, 2025 },
                    { 173, 27804052712418L, 48, "مرض السكري النوع الثاني", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 3, "Not Dangerous", 9, 2025 },
                    { 174, 28305082247721L, 43, "الحمى الصفراء", new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", true, true, false, 10, "Strong", 43, 2025 },
                    { 175, 30003161277233L, 26, "التسمم الغذائي", new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", true, true, false, 9, "Weak", 37, 2025 },
                    { 176, 27812022235017L, 47, "مرض السكري النوع الثاني", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 1, "Not Dangerous", 1, 2025 },
                    { 177, 25904102727424L, 67, "الأنيميا", new DateTime(2025, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 9, "Not Dangerous", 38, 2025 },
                    { 178, 25501032488425L, 71, "مرض السكري النوع الثاني", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, true, 9, "Not Dangerous", 38, 2025 },
                    { 179, 29704192792019L, 29, "قصور الغدة الدرقية", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 3, "Not Dangerous", 13, 2025 },
                    { 180, 26405041823548L, 62, "مرض السكري النوع الثاني", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 181, 29606011937936L, 30, "التهاب الكبد A", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 6, "Medium", 24, 2025 },
                    { 182, 29911162058212L, 26, "الأنيميا", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 1, "Not Dangerous", 1, 2025 },
                    { 183, 27510081922745L, 50, "آلام الظهر المزمنة", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 184, 29902021581915L, 27, "الجمرة الخبيثة", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, false, 2, "Strong", 7, 2025 },
                    { 185, 27904202293424L, 47, "آلام الظهر المزمنة", new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 186, 29102280933313L, 35, "مرض السكري النوع الثاني", new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, true, 7, "Not Dangerous", 30, 2025 },
                    { 187, 29807060933612L, 27, "مرض السكري النوع الثاني", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 1, "Not Dangerous", 5, 2025 },
                    { 188, 27103260725647L, 55, "التهاب اللوزتين الحاد", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 3, "Not Dangerous", 13, 2025 },
                    { 189, 29711141255012L, 28, "السعال الديكي", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", true, true, true, 2, "Weak", 8, 2025 },
                    { 190, 29304222143823L, 33, "التهاب اللوزتين الحاد", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 191, 27312052010538L, 52, "الحصبة", new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", true, true, false, 4, "Medium", 15, 2025 },
                    { 192, 29402051031646L, 32, "الحموضة وارتجاع المريء", new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 7, "Not Dangerous", 29, 2025 },
                    { 193, 28612021557035L, 39, "الصداع النصفي", new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 11, "Not Dangerous", 48, 2025 },
                    { 194, 27008262663545L, 55, "الحصبة", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, true, 1, "Medium", 1, 2025 },
                    { 195, 29709171562135L, 28, "التهاب المفاصل", new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 7, "Not Dangerous", 29, 2025 },
                    { 196, 29809162071039L, 27, "الصداع النصفي", new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 4, "Not Dangerous", 16, 2025 },
                    { 197, 26802151998438L, 58, "قصور الغدة الدرقية", new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 5, "Not Dangerous", 18, 2025 },
                    { 198, 29906031231545L, 27, "قصور الغدة الدرقية", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 3, "Not Dangerous", 10, 2025 },
                    { 199, 29205150754615L, 34, "شلل الأطفال", new DateTime(2026, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, false, false, 6, "Strong", 23, 2026 },
                    { 200, 27001270566649L, 56, "التهاب الجيوب الأنفية", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 201, 27501241555734L, 51, "التهاب المسالك البولية", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 8, "Not Dangerous", 33, 2025 },
                    { 202, 29902221029018L, 27, "السعال الديكي", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, true, false, 1, "Weak", 2, 2025 },
                    { 203, 29203081458321L, 34, "آلام الظهر المزمنة", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 10, "Not Dangerous", 40, 2025 },
                    { 204, 25702021327917L, 69, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 205, 26208260666922L, 63, "التهاب المفاصل", new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 206, 26704012644443L, 59, "آلام الظهر المزمنة", new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 11, "Not Dangerous", 48, 2025 },
                    { 207, 28409091494121L, 41, "الجدري المائي", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", true, true, false, 3, "Weak", 10, 2025 },
                    { 208, 28511182799226L, 40, "آلام الظهر المزمنة", new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 3, "Not Dangerous", 13, 2025 },
                    { 209, 27003251965448L, 56, "التهاب المعدة والأمعاء", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 4, "Not Dangerous", 14, 2025 },
                    { 210, 26703070444031L, 59, "ارتفاع ضغط الدم", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 12, "Not Dangerous", 49, 2025 },
                    { 211, 27809150890235L, 47, "الطاعون", new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", true, true, false, 5, "Strong", 19, 2025 },
                    { 212, 29307172516614L, 32, "التهاب الكبد C", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, false, 10, "Medium", 42, 2025 },
                    { 213, 25707260961746L, 68, "التهاب المعدة والأمعاء", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 11, "Not Dangerous", 46, 2025 },
                    { 214, 26912140631411L, 56, "التهاب المعدة والأمعاء", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, false, 1, "Not Dangerous", 1, 2025 },
                    { 215, 29609191652827L, 29, "الربو القصبي", new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 1, "Not Dangerous", 4, 2025 },
                    { 216, 29506230674444L, 30, "التهاب الأذن الوسطى", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 10, "Not Dangerous", 40, 2025 },
                    { 217, 26304081958943L, 63, "آلام الظهر المزمنة", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 12, "Not Dangerous", 51, 2025 },
                    { 218, 30404280672735L, 22, "التهاب المفاصل", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 1, "Not Dangerous", 3, 2025 },
                    { 219, 29512171988733L, 30, "التهاب اللوزتين الحاد", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 220, 28112070413428L, 44, "الحمى النزفية الفيروسية", new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", true, true, true, 8, "Strong", 31, 2025 },
                    { 221, 26802151998438L, 58, "ارتفاع ضغط الدم", new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 3, "Not Dangerous", 12, 2025 },
                    { 222, 29911162058212L, 26, "الصداع النصفي", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, true, 3, "Not Dangerous", 12, 2025 },
                    { 223, 26512160881922L, 60, "ارتفاع ضغط الدم", new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 6, "Not Dangerous", 23, 2025 },
                    { 224, 28907162425713L, 36, "التهاب اللوزتين الحاد", new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, true, 6, "Not Dangerous", 26, 2025 },
                    { 225, 28304251063124L, 43, "التهاب المعدة والأمعاء", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 10, "Not Dangerous", 40, 2025 },
                    { 226, 26802022578942L, 58, "التهاب الجيوب الأنفية", new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 4, "Not Dangerous", 16, 2025 },
                    { 227, 28612171286746L, 39, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Female", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 228, 28109171082233L, 44, "التهاب الأذن الوسطى", new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 229, 28810260432426L, 37, "الأنيميا", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 3, "Not Dangerous", 13, 2025 },
                    { 230, 29602101223226L, 30, "مرض السكري النوع الثاني", new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 5, "Not Dangerous", 19, 2025 },
                    { 231, 26311042578026L, 62, "التهاب المسالك البولية", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 1, "Not Dangerous", 3, 2025 },
                    { 232, 27110191267934L, 54, "الربو القصبي", new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 4, "Not Dangerous", 17, 2025 },
                    { 233, 29907180467736L, 26, "الطاعون", new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, true, 12, "Strong", 52, 2025 },
                    { 234, 26307020364649L, 62, "الأنيميا", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 3, "Not Dangerous", 13, 2025 },
                    { 235, 27007121572627L, 55, "ارتفاع ضغط الدم", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 236, 28612021557035L, 39, "قصور الغدة الدرقية", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 3, "Not Dangerous", 11, 2025 },
                    { 237, 30002142030623L, 26, "الحموضة وارتجاع المريء", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 8, "Not Dangerous", 34, 2025 },
                    { 238, 30402041591623L, 22, "ارتفاع ضغط الدم", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 1, "Not Dangerous", 4, 2025 },
                    { 239, 26209092311726L, 63, "مرض السكري النوع الثاني", new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 7, "Not Dangerous", 28, 2025 },
                    { 240, 27402270257328L, 52, "قصور الغدة الدرقية", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 5, "Not Dangerous", 22, 2025 },
                    { 241, 28303242043947L, 43, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", false, true, true, 5, "Not Dangerous", 22, 2025 },
                    { 242, 29902021581915L, 27, "التهاب المفاصل", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 1, "Not Dangerous", 1, 2025 },
                    { 243, 29205212724525L, 34, "التهاب المسالك البولية", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 1, "Not Dangerous", 4, 2025 },
                    { 244, 29502011495033L, 31, "ارتفاع ضغط الدم", new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, true, 7, "Not Dangerous", 29, 2025 },
                    { 245, 28109171082233L, 44, "مرض السكري النوع الثاني", new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 8, "Not Dangerous", 35, 2025 },
                    { 246, 28109140485342L, 44, "التهاب الجيوب الأنفية", new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 9, "Not Dangerous", 40, 2025 },
                    { 247, 28201050321836L, 44, "ارتفاع ضغط الدم", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 248, 26001251776233L, 66, "النكاف", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, false, 3, "Weak", 10, 2025 },
                    { 249, 27007171823145L, 55, "الحموضة وارتجاع المريء", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 1, "Not Dangerous", 2, 2025 },
                    { 250, 28310131632728L, 42, "قصور الغدة الدرقية", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, false, 2, "Not Dangerous", 7, 2025 },
                    { 251, 29506230674444L, 30, "الصداع النصفي", new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 252, 26512160881922L, 60, "التهاب الكبد B", new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, true, 7, "Medium", 29, 2025 },
                    { 253, 29906031231545L, 27, "آلام الظهر المزمنة", new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 254, 29105160449241L, 35, "الحموضة وارتجاع المريء", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 2, "Not Dangerous", 7, 2025 },
                    { 255, 26012032527324L, 65, "التهاب الكبد A", new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", true, true, false, 7, "Medium", 27, 2025 },
                    { 256, 27501121188627L, 51, "السل الرئوي", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", true, true, false, 3, "Medium", 11, 2025 },
                    { 257, 29402051031646L, 32, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Female", false, true, true, 11, "Not Dangerous", 46, 2025 },
                    { 258, 26405060651914L, 62, "التهاب في الجهاز التنفسي العلوي", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, false, 10, "Not Dangerous", 41, 2025 },
                    { 259, 29705131626346L, 29, "التهاب المسالك البولية", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", false, true, false, 9, "Not Dangerous", 38, 2025 },
                    { 260, 29711141255012L, 28, "الصداع النصفي", new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 1, "Not Dangerous", 3, 2025 },
                    { 261, 26901220186821L, 57, "آلام الظهر المزمنة", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, true, 8, "Not Dangerous", 35, 2025 },
                    { 262, 27411271071314L, 51, "التهاب الجيوب الأنفية", new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 5, "Not Dangerous", 22, 2025 },
                    { 263, 28801100412539L, 38, "آلام الظهر المزمنة", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Male", false, true, true, 8, "Not Dangerous", 34, 2025 },
                    { 264, 28810260432426L, 37, "الجمرة الخبيثة", new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Female", true, true, false, 7, "Strong", 28, 2025 },
                    { 265, 29709171562135L, 28, "التهاب الجيوب الأنفية", new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 7, "Not Dangerous", 28, 2025 },
                    { 266, 29604230552116L, 30, "التهاب الأذن الوسطى", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 8, "Not Dangerous", 34, 2025 },
                    { 267, 28310120163531L, 42, "الحموضة وارتجاع المريء", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 9, "Not Dangerous", 39, 2025 },
                    { 268, 27902182124842L, 47, "التهاب المسالك البولية", new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 7, "Not Dangerous", 29, 2025 },
                    { 269, 30512110377845L, 20, "التهاب الجيوب الأنفية", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 10, "Not Dangerous", 40, 2025 },
                    { 270, 26705181427449L, 59, "قصور الغدة الدرقية", new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 271, 25612140799836L, 69, "قصور الغدة الدرقية", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 10, "Not Dangerous", 40, 2025 },
                    { 272, 25910191374939L, 66, "التهاب المعدة والأمعاء", new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, true, 6, "Not Dangerous", 23, 2025 },
                    { 273, 29510220742437L, 30, "التهاب المفاصل", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, true, 1, "Not Dangerous", 2, 2025 },
                    { 274, 25707260961746L, 68, "التهاب المعدة والأمعاء", new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 7, "Not Dangerous", 29, 2025 },
                    { 275, 29004151684228L, 36, "السعال الديكي", new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 1, "Weak", 5, 2025 },
                    { 276, 29810110723133L, 27, "التهاب المعدة والأمعاء", new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 4, "Not Dangerous", 15, 2025 },
                    { 277, 30502011419048L, 21, "الجدري المائي", new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Female", true, true, false, 3, "Weak", 13, 2025 },
                    { 278, 26907131787138L, 56, "مرض السكري النوع الثاني", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", false, true, false, 5, "Not Dangerous", 22, 2025 },
                    { 279, 29307172516614L, 32, "التهاب المسالك البولية", new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, false, 12, "Not Dangerous", 52, 2025 },
                    { 280, 26603232370334L, 60, "السعال الديكي", new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", true, true, false, 3, "Weak", 14, 2025 },
                    { 281, 30104091429444L, 25, "التهاب المفاصل", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, false, 3, "Not Dangerous", 9, 2025 },
                    { 282, 26606212365548L, 59, "التهاب المعدة والأمعاء", new DateTime(2025, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 9, "Not Dangerous", 36, 2025 },
                    { 283, 28102062231211L, 45, "التهاب الجيوب الأنفية", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 6, "Not Dangerous", 24, 2025 },
                    { 284, 27903231064334L, 47, "التهاب اللوزتين الحاد", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", false, true, false, 3, "Not Dangerous", 12, 2025 },
                    { 285, 26802151998438L, 58, "آلام الظهر المزمنة", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 1, "Not Dangerous", 5, 2025 },
                    { 286, 26404161084839L, 62, "التهاب الأذن الوسطى", new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 6, "Not Dangerous", 26, 2025 },
                    { 287, 26609101969639L, 59, "ارتفاع ضغط الدم", new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, true, 5, "Not Dangerous", 20, 2025 },
                    { 288, 28103171378429L, 45, "التهاب المفاصل", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Female", false, true, true, 10, "Not Dangerous", 40, 2025 },
                    { 289, 29205130926512L, 34, "الحمى الصفراء", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", true, true, false, 2, "Strong", 8, 2025 },
                    { 290, 28304251063124L, 43, "التهاب المسالك البولية", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, true, 1, "Not Dangerous", 3, 2025 },
                    { 291, 29901190376634L, 27, "الربو القصبي", new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Male", false, true, false, 10, "Not Dangerous", 42, 2025 },
                    { 292, 26110032684141L, 64, "مرض السكري النوع الثاني", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Female", false, true, false, 3, "Not Dangerous", 9, 2025 },
                    { 293, 28410112142732L, 41, "الجمرة الخبيثة", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Male", true, true, false, 12, "Strong", 49, 2025 },
                    { 294, 29709171562135L, 28, "مرض السكري النوع الثاني", new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Male", false, true, true, 4, "Not Dangerous", 17, 2025 },
                    { 295, 29103232014939L, 35, "التهاب الأذن الوسطى", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Male", false, true, false, 5, "Not Dangerous", 20, 2025 },
                    { 296, 27904202293424L, 47, "التهاب الأذن الوسطى", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", false, true, false, 8, "Not Dangerous", 33, 2025 },
                    { 297, 30312031681246L, 22, "التهاب الأذن الوسطى", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Female", false, true, true, 8, "Not Dangerous", 33, 2025 },
                    { 298, 28903280265834L, 37, "التهاب اللوزتين الحاد", new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Male", false, true, false, 10, "Not Dangerous", 43, 2025 },
                    { 299, 27605182799835L, 50, "الكوليرا", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Male", true, true, false, 8, "Strong", 33, 2025 },
                    { 300, 27207010318911L, 53, "التهاب اللوزتين الحاد", new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", false, true, true, 12, "Not Dangerous", 49, 2025 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 1, 25905011269245L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 2, 26609101969639L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 3, 27302092052212L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 4, 27110191267934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 5, 26911231450414L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 6, 26103191967218L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 7, 28205142294615L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 8, 27904202293424L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 9, 29009180595917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 10, 26102161683017L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 11, 29911261271836L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 12, 29706262713545L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 13, 28203202548635L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 14, 29711141255012L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 15, 28201110715133L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 16, 30406061549427L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 17, 28309012086142L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 18, 27905010710646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 19, 25912210595421L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 20, 30406152649934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 21, 29409112072647L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 22, 29309181152935L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 23, 26802022578942L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 24, 25604050674431L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 25, 25802082334821L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 26, 29710152380223L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 27, 26810030349019L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 28, 28502111480343L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 29, 27501121188627L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 30, 27303011846934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 31, 28310150453012L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 32, 28705190974544L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 33, 27710080619122L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 34, 28201110715133L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 35, 29309181152935L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 36, 26601240218847L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 37, 28109171082233L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 38, 25904101989836L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 39, 29208011553646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 40, 25904012281337L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 41, 26704012644443L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 42, 25508220421416L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 43, 27301211520721L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 44, 26310240723715L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 45, 26105142352636L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 46, 27312052010538L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 47, 29906211729838L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 48, 28003081867814L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 49, 26104061447744L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 50, 28404160791449L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 51, 28302130650018L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 52, 26903011925532L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 53, 27505141187023L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 54, 26207070450518L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 55, 25609150911841L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 56, 27510041789444L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 57, 26604102257635L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 58, 29805050237031L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 59, 27506072316524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 60, 26911102765112L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 61, 25706241388934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 62, 25911201723239L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 63, 29807060933612L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 64, 26911242719819L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 65, 27008262663545L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 66, 29507171411419L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 67, 28112070413428L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 68, 27501121188627L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 69, 28102062231211L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 70, 26512100991915L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 71, 29105160449241L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 72, 26405041823548L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 73, 29706231097023L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 74, 29606140660042L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 75, 29609181438041L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 76, 26812252287219L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 77, 26204021610825L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 78, 29511200559448L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 79, 25904012281337L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 80, 29711141255012L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 81, 26809072274323L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 82, 26810030349019L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 83, 29912142763041L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 84, 27206150576843L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 85, 26210200423442L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 86, 29210181337133L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 87, 30302121229811L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 88, 27807170354432L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 89, 28310131632728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 90, 28109140485342L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 91, 29309181152935L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 92, 29411140287447L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 93, 29602101223226L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 94, 29009180595917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 95, 29004151684228L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 96, 25707260961746L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 97, 26712040942519L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 98, 26802151998438L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 99, 26803152251546L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 100, 29812011274846L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 101, 27906020778748L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 102, 26512160881922L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 103, 26110011015343L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 104, 26207070450518L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 105, 30408110458418L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 106, 27010231899225L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 107, 26802200544638L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 108, 29907180467736L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 109, 29707182119014L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 110, 29907180467736L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 111, 28608180783613L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 112, 29509201483533L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 113, 26404161084839L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 114, 27707162418322L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 115, 29703250556636L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 116, 25507071264728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 117, 29110192631047L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 118, 29709171562135L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 119, 28810112499039L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 120, 27707162418322L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 121, 28208070953031L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 122, 26403050919049L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 123, 28805101046625L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 124, 27304051311349L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 125, 27611162373234L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 126, 26911242719819L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 127, 26106170545821L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 128, 26001251776233L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 129, 27506072316524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 130, 28404172440533L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 131, 27509102343431L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 132, 30210112797917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 133, 29307172516614L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 134, 29211271336524L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 135, 29606190935334L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 136, 28109140485342L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 137, 26810030349019L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 138, 29704192792019L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 139, 25609150911841L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 140, 27301192714834L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 141, 30111041134926L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 142, 26209250732445L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 143, 25807092627218L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 144, 26603031269339L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 145, 29512171988733L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 146, 26710060835422L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 147, 28908152583844L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 148, 26103191967218L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 149, 26808261599031L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 150, 27302092052212L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 151, 29901190376634L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 152, 29903262470515L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 153, 29401140884613L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 154, 29609181438041L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 155, 25706241388934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 156, 27403240425049L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 157, 29502030963945L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 158, 27007121572627L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 159, 28103171378429L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 160, 27807170354432L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 161, 27908091222948L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 162, 29802202443343L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 163, 29906171167018L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 164, 26711271888735L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 165, 27612260840312L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 166, 28404160791449L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 167, 28710042492533L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 168, 25710272789132L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 169, 29205150754615L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 170, 28907181573718L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 171, 26509160450543L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 172, 26911231450414L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 173, 27804052712418L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 174, 28305082247721L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 175, 30003161277233L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 176, 27812022235017L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 177, 25904102727424L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 178, 25501032488425L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 179, 29704192792019L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 180, 26405041823548L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 181, 29606011937936L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 182, 29911162058212L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 183, 27510081922745L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 184, 29902021581915L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 185, 27904202293424L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 186, 29102280933313L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 187, 29807060933612L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 188, 27103260725647L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 189, 29711141255012L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 190, 29304222143823L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 191, 27312052010538L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 192, 29402051031646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 193, 28612021557035L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 194, 27008262663545L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 195, 29709171562135L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 196, 29809162071039L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 197, 26802151998438L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 198, 29906031231545L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 199, 29205150754615L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 200, 27001270566649L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 201, 27501241555734L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 202, 29902221029018L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 203, 29203081458321L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 204, 25702021327917L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 205, 26208260666922L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 206, 26704012644443L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 207, 28409091494121L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 208, 28511182799226L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 209, 27003251965448L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 210, 26703070444031L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 211, 27809150890235L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 212, 29307172516614L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 213, 25707260961746L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 214, 26912140631411L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 215, 29609191652827L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 216, 29506230674444L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 217, 26304081958943L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 218, 30404280672735L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 219, 29512171988733L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 220, 28112070413428L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 221, 26802151998438L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 222, 29911162058212L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 223, 26512160881922L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 224, 28907162425713L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 225, 28304251063124L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 226, 26802022578942L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 227, 28612171286746L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 228, 28109171082233L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 229, 28810260432426L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 230, 29602101223226L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 231, 26311042578026L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 232, 27110191267934L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 233, 29907180467736L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 234, 26307020364649L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 235, 27007121572627L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 236, 28612021557035L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 237, 30002142030623L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 238, 30402041591623L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 239, 26209092311726L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 240, 27402270257328L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 241, 28303242043947L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 242, 29902021581915L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 243, 29205212724525L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 244, 29502011495033L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 245, 28109171082233L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 246, 28109140485342L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 247, 28201050321836L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 248, 26001251776233L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 249, 27007171823145L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 250, 28310131632728L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 251, 29506230674444L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 252, 26512160881922L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 253, 29906031231545L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 254, 29105160449241L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 255, 26012032527324L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 256, 27501121188627L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 257, 29402051031646L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 258, 26405060651914L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 259, 29705131626346L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 260, 29711141255012L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 261, 26901220186821L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 262, 27411271071314L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 263, 28801100412539L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 264, 28810260432426L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 265, 29709171562135L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 266, 29604230552116L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 267, 28310120163531L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 268, 27902182124842L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 269, 30512110377845L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 270, 26705181427449L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 271, 25612140799836L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 272, 25910191374939L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 273, 29510220742437L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 274, 25707260961746L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 275, 29004151684228L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 276, 29810110723133L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 277, 30502011419048L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 278, 26907131787138L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 279, 29307172516614L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 280, 26603232370334L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 281, 30104091429444L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 282, 26606212365548L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 283, 28102062231211L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 284, 27903231064334L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 285, 26802151998438L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 286, 26404161084839L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 287, 26609101969639L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 288, 28103171378429L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 289, 29205130926512L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 290, 28304251063124L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 291, 29901190376634L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 292, 26110032684141L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 293, 28410112142732L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 294, 29709171562135L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 295, 29103232014939L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 296, 27904202293424L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 297, 30312031681246L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 298, 28903280265834L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 299, 27605182799835L });

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 300, 27207010318911L });
        }
    }
}
