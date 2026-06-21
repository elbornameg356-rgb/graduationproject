using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutpatientClinicsComplex.Migrations
{
    /// <inheritdoc />
    public partial class datasettestresults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "Id", "NationalId", "LabTechnicianCode", "RequiredTestId", "ResultTests" },
                values: new object[,]
                {
                    { 1, 28712250827841L, 2, 1, "مرتفع قليلاً - Slightly High" },
                    { 3, 26304081958943L, 1, 3, "إيجابي - Positive" },
                    { 4, 29104112764219L, 3, 4, "مرتفع قليلاً - Slightly High" },
                    { 5, 29609162011614L, 2, 5, "طبيعي - Normal" },
                    { 6, 29609191652827L, 2, 6, "في الحدود الطبيعية" },
                    { 7, 30312031327335L, 2, 7, "إيجابي - Positive" },
                    { 8, 29704262256412L, 3, 8, "يحتاج متابعة - Follow Up" },
                    { 11, 27102180311546L, 3, 11, "في الحدود الطبيعية" },
                    { 12, 30510280399723L, 2, 12, "طبيعي - Normal" },
                    { 13, 29911162058212L, 1, 13, "مرتفع بشكل ملحوظ - High" },
                    { 14, 27905010710646L, 1, 14, "يحتاج متابعة - Follow Up" },
                    { 15, 26012032527324L, 1, 15, "منخفض - Low" },
                    { 16, 27402190215935L, 2, 16, "إيجابي - Positive" },
                    { 18, 29607110985423L, 1, 18, "منخفض - Low" },
                    { 19, 26903240593732L, 4, 19, "إيجابي - Positive" },
                    { 20, 30412031269123L, 3, 20, "مرتفع بشكل ملحوظ - High" },
                    { 22, 26609101969639L, 1, 22, "في الحدود الطبيعية" },
                    { 24, 25601190374917L, 2, 24, "سلبي - Negative" },
                    { 26, 28506221177223L, 4, 26, "إيجابي - Positive" },
                    { 28, 28109140485342L, 1, 28, "إيجابي - Positive" },
                    { 29, 25508111486644L, 3, 29, "يحتاج متابعة - Follow Up" },
                    { 31, 29011272346948L, 1, 31, "طبيعي - Normal" },
                    { 32, 30211281664546L, 1, 32, "سلبي - Negative" },
                    { 35, 29104112764219L, 4, 4, "إيجابي - Positive" },
                    { 36, 27911070557216L, 2, 36, "يحتاج متابعة - Follow Up" },
                    { 38, 26705181427449L, 3, 38, "يحتاج متابعة - Follow Up" },
                    { 40, 29607110985423L, 1, 18, "منخفض - Low" },
                    { 41, 28708270328423L, 4, 41, "منخفض - Low" },
                    { 42, 26110032684141L, 4, 42, "يحتاج متابعة - Follow Up" },
                    { 44, 25601051694214L, 4, 44, "سلبي - Negative" },
                    { 45, 26305201632248L, 2, 45, "طبيعي - Normal" },
                    { 46, 27411271071314L, 3, 46, "يحتاج متابعة - Follow Up" },
                    { 48, 30012182755017L, 2, 48, "منخفض - Low" },
                    { 49, 30502011419048L, 4, 49, "سلبي - Negative" },
                    { 52, 28109192219726L, 1, 52, "منخفض - Low" },
                    { 56, 30510280399723L, 3, 12, "إيجابي - Positive" },
                    { 57, 26202071747247L, 1, 57, "مرتفع قليلاً - Slightly High" },
                    { 59, 29205121611912L, 2, 59, "مرتفع قليلاً - Slightly High" },
                    { 61, 26712220578842L, 2, 61, "مرتفع قليلاً - Slightly High" },
                    { 62, 26911102765112L, 1, 62, "منخفض - Low" },
                    { 63, 29807060933612L, 4, 63, "إيجابي - Positive" },
                    { 64, 26209250732445L, 1, 64, "في الحدود الطبيعية" },
                    { 67, 29908282553214L, 3, 67, "منخفض - Low" },
                    { 68, 28103212755522L, 1, 68, "مرتفع قليلاً - Slightly High" },
                    { 69, 26101111663415L, 4, 69, "إيجابي - Positive" },
                    { 70, 28309130411441L, 4, 70, "منخفض - Low" },
                    { 71, 26103191967218L, 3, 71, "سلبي - Negative" },
                    { 72, 27707162418322L, 4, 72, "منخفض - Low" },
                    { 73, 26403212767321L, 2, 73, "في الحدود الطبيعية" },
                    { 75, 28507111572434L, 3, 75, "مرتفع قليلاً - Slightly High" },
                    { 76, 29606140660042L, 4, 76, "يحتاج متابعة - Follow Up" },
                    { 77, 27812022235017L, 3, 77, "مرتفع بشكل ملحوظ - High" },
                    { 80, 29305112434533L, 2, 80, "مرتفع بشكل ملحوظ - High" },
                    { 82, 28010051198022L, 2, 82, "منخفض - Low" },
                    { 86, 27302092052212L, 2, 86, "منخفض - Low" },
                    { 87, 26902091750426L, 2, 87, "سلبي - Negative" },
                    { 88, 29706262713545L, 2, 88, "مرتفع بشكل ملحوظ - High" },
                    { 89, 28612021557035L, 1, 89, "منخفض - Low" },
                    { 90, 27707162418322L, 1, 72, "مرتفع قليلاً - Slightly High" },
                    { 91, 29812011274846L, 3, 91, "يحتاج متابعة - Follow Up" },
                    { 92, 30411030272531L, 1, 92, "إيجابي - Positive" },
                    { 94, 27604181195219L, 1, 94, "مرتفع بشكل ملحوظ - High" },
                    { 95, 29208011553646L, 2, 95, "يحتاج متابعة - Follow Up" },
                    { 96, 25904101989836L, 3, 96, "إيجابي - Positive" },
                    { 97, 30304030147041L, 4, 97, "مرتفع قليلاً - Slightly High" },
                    { 99, 28805221769315L, 2, 99, "سلبي - Negative" },
                    { 100, 28203202548635L, 1, 27, "إيجابي - Positive" },
                    { 101, 27103260725647L, 4, 101, "مرتفع بشكل ملحوظ - High" },
                    { 102, 29604230552116L, 2, 84, "منخفض - Low" },
                    { 103, 28304251063124L, 4, 103, "مرتفع بشكل ملحوظ - High" },
                    { 104, 28004091523821L, 1, 104, "في الحدود الطبيعية" },
                    { 106, 29605240851446L, 1, 106, "في الحدود الطبيعية" },
                    { 107, 29305112434533L, 2, 80, "سلبي - Negative" },
                    { 110, 30210112797917L, 2, 110, "في الحدود الطبيعية" },
                    { 111, 27206150576843L, 1, 111, "يحتاج متابعة - Follow Up" },
                    { 113, 30508200661511L, 2, 66, "سلبي - Negative" },
                    { 114, 29103232014939L, 1, 114, "منخفض - Low" },
                    { 115, 28102062231211L, 2, 115, "منخفض - Low" },
                    { 117, 27906010614734L, 2, 117, "إيجابي - Positive" },
                    { 119, 25706241388934L, 2, 119, "منخفض - Low" },
                    { 120, 28710042492533L, 2, 120, "إيجابي - Positive" },
                    { 122, 30412130970331L, 2, 122, "مرتفع بشكل ملحوظ - High" },
                    { 123, 30406152649934L, 4, 123, "إيجابي - Positive" },
                    { 126, 25911222551648L, 2, 126, "إيجابي - Positive" },
                    { 129, 29105272661018L, 2, 129, "إيجابي - Positive" },
                    { 130, 29103232014939L, 2, 114, "مرتفع قليلاً - Slightly High" },
                    { 131, 25612140799836L, 1, 131, "في الحدود الطبيعية" },
                    { 133, 27402190215935L, 3, 16, "مرتفع بشكل ملحوظ - High" },
                    { 134, 26512160881922L, 2, 134, "مرتفع قليلاً - Slightly High" },
                    { 135, 27506181320721L, 4, 135, "إيجابي - Positive" },
                    { 137, 28203202548635L, 2, 27, "سلبي - Negative" },
                    { 138, 29610040117014L, 1, 138, "سلبي - Negative" },
                    { 139, 26011271939936L, 3, 139, "يحتاج متابعة - Follow Up" },
                    { 141, 26603031269339L, 4, 141, "مرتفع بشكل ملحوظ - High" },
                    { 142, 26405041823548L, 2, 142, "منخفض - Low" },
                    { 144, 27604181195219L, 3, 94, "يحتاج متابعة - Follow Up" },
                    { 145, 29607110985423L, 2, 18, "طبيعي - Normal" },
                    { 146, 27301211520721L, 4, 116, "سلبي - Negative" },
                    { 147, 27204041387323L, 1, 147, "طبيعي - Normal" },
                    { 151, 28507011226947L, 1, 151, "سلبي - Negative" },
                    { 152, 27807060786621L, 4, 152, "إيجابي - Positive" },
                    { 154, 25906212410441L, 3, 121, "في الحدود الطبيعية" },
                    { 155, 27411271071314L, 1, 46, "في الحدود الطبيعية" },
                    { 156, 29706231097023L, 2, 156, "في الحدود الطبيعية" },
                    { 157, 28302130650018L, 3, 157, "مرتفع بشكل ملحوظ - High" },
                    { 158, 25807092627218L, 4, 158, "يحتاج متابعة - Follow Up" },
                    { 159, 29907180467736L, 1, 159, "مرتفع قليلاً - Slightly High" },
                    { 160, 26809072274323L, 4, 160, "منخفض - Low" },
                    { 161, 29704262256412L, 4, 8, "طبيعي - Normal" },
                    { 162, 26710060835422L, 2, 162, "في الحدود الطبيعية" },
                    { 163, 28903280265834L, 3, 163, "يحتاج متابعة - Follow Up" },
                    { 164, 26712172611438L, 4, 164, "في الحدود الطبيعية" },
                    { 167, 26909112682924L, 1, 167, "منخفض - Low" },
                    { 168, 25910170263539L, 4, 168, "في الحدود الطبيعية" },
                    { 170, 27908091222948L, 4, 170, "إيجابي - Positive" },
                    { 171, 29902221029018L, 2, 148, "منخفض - Low" },
                    { 176, 28205142294615L, 2, 176, "في الحدود الطبيعية" },
                    { 178, 28312052272832L, 4, 178, "في الحدود الطبيعية" },
                    { 179, 26311211430532L, 3, 179, "في الحدود الطبيعية" },
                    { 180, 30010101882722L, 4, 180, "يحتاج متابعة - Follow Up" },
                    { 182, 27001270195412L, 4, 182, "مرتفع قليلاً - Slightly High" },
                    { 183, 29810110723133L, 2, 10, "طبيعي - Normal" },
                    { 184, 29102280933313L, 2, 184, "إيجابي - Positive" },
                    { 185, 27209080313425L, 2, 185, "مرتفع قليلاً - Slightly High" },
                    { 188, 25709052724847L, 3, 188, "مرتفع قليلاً - Slightly High" },
                    { 189, 28004091523821L, 2, 104, "إيجابي - Positive" },
                    { 190, 28710042492533L, 2, 120, "مرتفع بشكل ملحوظ - High" },
                    { 191, 26601172079928L, 2, 191, "في الحدود الطبيعية" },
                    { 193, 28511182799226L, 3, 193, "يحتاج متابعة - Follow Up" },
                    { 194, 26307020364649L, 3, 194, "طبيعي - Normal" },
                    { 195, 26512100991915L, 3, 195, "مرتفع قليلاً - Slightly High" },
                    { 197, 28708170770338L, 3, 197, "منخفض - Low" },
                    { 199, 27611162373234L, 4, 199, "مرتفع قليلاً - Slightly High" },
                    { 200, 25902242271316L, 3, 200, "مرتفع قليلاً - Slightly High" },
                    { 201, 29805050237031L, 1, 201, "يحتاج متابعة - Follow Up" },
                    { 205, 26509160450543L, 2, 205, "طبيعي - Normal" },
                    { 206, 26712220578842L, 2, 61, "مرتفع بشكل ملحوظ - High" },
                    { 211, 29402051031646L, 2, 211, "في الحدود الطبيعية" },
                    { 212, 25608151831317L, 1, 212, "إيجابي - Positive" },
                    { 213, 25709052724847L, 1, 188, "مرتفع قليلاً - Slightly High" },
                    { 214, 29502011495033L, 1, 214, "مرتفع قليلاً - Slightly High" },
                    { 215, 28506221177223L, 4, 26, "منخفض - Low" },
                    { 217, 27604181195219L, 4, 94, "منخفض - Low" },
                    { 219, 30512182354842L, 2, 219, "إيجابي - Positive" },
                    { 220, 25706241388934L, 1, 119, "مرتفع بشكل ملحوظ - High" },
                    { 222, 26901220186821L, 1, 150, "طبيعي - Normal" },
                    { 223, 26303212559348L, 2, 223, "مرتفع قليلاً - Slightly High" },
                    { 227, 29412240719842L, 3, 227, "سلبي - Negative" },
                    { 228, 27207010318911L, 3, 228, "إيجابي - Positive" },
                    { 229, 28612171286746L, 2, 229, "منخفض - Low" },
                    { 230, 29607121752623L, 4, 230, "منخفض - Low" },
                    { 232, 28511182799226L, 1, 193, "مرتفع قليلاً - Slightly High" },
                    { 234, 26601230933711L, 4, 234, "منخفض - Low" },
                    { 236, 28004091523821L, 3, 104, "مرتفع بشكل ملحوظ - High" },
                    { 237, 28910080232534L, 1, 237, "سلبي - Negative" },
                    { 238, 25804031762917L, 4, 238, "إيجابي - Positive" },
                    { 240, 27310072633431L, 1, 240, "يحتاج متابعة - Follow Up" },
                    { 244, 29704262256412L, 3, 8, "مرتفع بشكل ملحوظ - High" },
                    { 245, 27107201080846L, 4, 245, "مرتفع قليلاً - Slightly High" },
                    { 246, 29609191652827L, 4, 6, "في الحدود الطبيعية" },
                    { 248, 26405060651914L, 3, 248, "سلبي - Negative" },
                    { 249, 25911011421642L, 4, 249, "طبيعي - Normal" },
                    { 250, 28409091397634L, 2, 250, "طبيعي - Normal" },
                    { 251, 30504072762928L, 2, 251, "طبيعي - Normal" },
                    { 253, 28712250827841L, 4, 1, "في الحدود الطبيعية" },
                    { 254, 29405131845932L, 2, 254, "يحتاج متابعة - Follow Up" },
                    { 255, 25612030876039L, 2, 255, "إيجابي - Positive" },
                    { 257, 27905010710646L, 4, 14, "سلبي - Negative" },
                    { 258, 26903011925532L, 4, 210, "يحتاج متابعة - Follow Up" },
                    { 259, 29210182012448L, 1, 259, "مرتفع بشكل ملحوظ - High" },
                    { 260, 28405040354337L, 4, 260, "طبيعي - Normal" },
                    { 262, 28207160311936L, 4, 262, "إيجابي - Positive" },
                    { 263, 29205212724525L, 1, 83, "يحتاج متابعة - Follow Up" },
                    { 265, 25501032488425L, 3, 265, "مرتفع قليلاً - Slightly High" },
                    { 268, 29104112764219L, 2, 4, "مرتفع قليلاً - Slightly High" },
                    { 269, 28708170770338L, 1, 197, "يحتاج متابعة - Follow Up" },
                    { 270, 29709171562135L, 2, 270, "إيجابي - Positive" },
                    { 274, 28303242043947L, 3, 274, "في الحدود الطبيعية" },
                    { 275, 28103171378429L, 4, 275, "مرتفع بشكل ملحوظ - High" },
                    { 276, 28710042492533L, 4, 120, "مرتفع قليلاً - Slightly High" },
                    { 277, 26104061447744L, 2, 277, "سلبي - Negative" },
                    { 279, 26501251163248L, 1, 279, "في الحدود الطبيعية" },
                    { 281, 26106170545821L, 3, 281, "مرتفع بشكل ملحوظ - High" },
                    { 283, 26604102257635L, 4, 283, "إيجابي - Positive" },
                    { 284, 29010182669624L, 1, 284, "سلبي - Negative" },
                    { 285, 27412110150319L, 1, 285, "طبيعي - Normal" },
                    { 286, 25508111486644L, 3, 29, "منخفض - Low" },
                    { 287, 30010101882722L, 1, 180, "يحتاج متابعة - Follow Up" },
                    { 289, 29609191652827L, 4, 6, "طبيعي - Normal" },
                    { 290, 29906171167018L, 4, 290, "مرتفع قليلاً - Slightly High" },
                    { 293, 27008262663545L, 2, 293, "طبيعي - Normal" },
                    { 296, 28703261733539L, 4, 34, "سلبي - Negative" },
                    { 297, 29704192792019L, 1, 288, "طبيعي - Normal" },
                    { 298, 27601281095222L, 1, 298, "مرتفع بشكل ملحوظ - High" },
                    { 302, 26710060835422L, 3, 162, "مرتفع بشكل ملحوظ - High" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 1, 28712250827841L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 3, 26304081958943L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 4, 29104112764219L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 5, 29609162011614L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 6, 29609191652827L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 7, 30312031327335L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 8, 29704262256412L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 11, 27102180311546L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 12, 30510280399723L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 13, 29911162058212L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 14, 27905010710646L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 15, 26012032527324L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 16, 27402190215935L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 18, 29607110985423L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 19, 26903240593732L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 20, 30412031269123L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 22, 26609101969639L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 24, 25601190374917L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 26, 28506221177223L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 28, 28109140485342L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 29, 25508111486644L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 31, 29011272346948L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 32, 30211281664546L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 35, 29104112764219L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 36, 27911070557216L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 38, 26705181427449L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 40, 29607110985423L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 41, 28708270328423L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 42, 26110032684141L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 44, 25601051694214L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 45, 26305201632248L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 46, 27411271071314L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 48, 30012182755017L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 49, 30502011419048L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 52, 28109192219726L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 56, 30510280399723L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 57, 26202071747247L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 59, 29205121611912L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 61, 26712220578842L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 62, 26911102765112L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 63, 29807060933612L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 64, 26209250732445L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 67, 29908282553214L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 68, 28103212755522L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 69, 26101111663415L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 70, 28309130411441L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 71, 26103191967218L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 72, 27707162418322L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 73, 26403212767321L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 75, 28507111572434L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 76, 29606140660042L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 77, 27812022235017L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 80, 29305112434533L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 82, 28010051198022L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 86, 27302092052212L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 87, 26902091750426L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 88, 29706262713545L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 89, 28612021557035L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 90, 27707162418322L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 91, 29812011274846L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 92, 30411030272531L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 94, 27604181195219L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 95, 29208011553646L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 96, 25904101989836L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 97, 30304030147041L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 99, 28805221769315L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 100, 28203202548635L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 101, 27103260725647L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 102, 29604230552116L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 103, 28304251063124L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 104, 28004091523821L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 106, 29605240851446L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 107, 29305112434533L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 110, 30210112797917L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 111, 27206150576843L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 113, 30508200661511L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 114, 29103232014939L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 115, 28102062231211L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 117, 27906010614734L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 119, 25706241388934L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 120, 28710042492533L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 122, 30412130970331L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 123, 30406152649934L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 126, 25911222551648L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 129, 29105272661018L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 130, 29103232014939L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 131, 25612140799836L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 133, 27402190215935L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 134, 26512160881922L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 135, 27506181320721L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 137, 28203202548635L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 138, 29610040117014L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 139, 26011271939936L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 141, 26603031269339L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 142, 26405041823548L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 144, 27604181195219L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 145, 29607110985423L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 146, 27301211520721L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 147, 27204041387323L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 151, 28507011226947L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 152, 27807060786621L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 154, 25906212410441L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 155, 27411271071314L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 156, 29706231097023L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 157, 28302130650018L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 158, 25807092627218L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 159, 29907180467736L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 160, 26809072274323L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 161, 29704262256412L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 162, 26710060835422L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 163, 28903280265834L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 164, 26712172611438L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 167, 26909112682924L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 168, 25910170263539L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 170, 27908091222948L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 171, 29902221029018L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 176, 28205142294615L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 178, 28312052272832L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 179, 26311211430532L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 180, 30010101882722L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 182, 27001270195412L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 183, 29810110723133L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 184, 29102280933313L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 185, 27209080313425L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 188, 25709052724847L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 189, 28004091523821L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 190, 28710042492533L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 191, 26601172079928L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 193, 28511182799226L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 194, 26307020364649L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 195, 26512100991915L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 197, 28708170770338L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 199, 27611162373234L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 200, 25902242271316L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 201, 29805050237031L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 205, 26509160450543L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 206, 26712220578842L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 211, 29402051031646L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 212, 25608151831317L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 213, 25709052724847L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 214, 29502011495033L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 215, 28506221177223L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 217, 27604181195219L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 219, 30512182354842L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 220, 25706241388934L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 222, 26901220186821L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 223, 26303212559348L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 227, 29412240719842L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 228, 27207010318911L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 229, 28612171286746L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 230, 29607121752623L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 232, 28511182799226L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 234, 26601230933711L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 236, 28004091523821L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 237, 28910080232534L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 238, 25804031762917L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 240, 27310072633431L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 244, 29704262256412L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 245, 27107201080846L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 246, 29609191652827L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 248, 26405060651914L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 249, 25911011421642L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 250, 28409091397634L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 251, 30504072762928L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 253, 28712250827841L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 254, 29405131845932L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 255, 25612030876039L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 257, 27905010710646L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 258, 26903011925532L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 259, 29210182012448L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 260, 28405040354337L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 262, 28207160311936L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 263, 29205212724525L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 265, 25501032488425L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 268, 29104112764219L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 269, 28708170770338L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 270, 29709171562135L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 274, 28303242043947L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 275, 28103171378429L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 276, 28710042492533L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 277, 26104061447744L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 279, 26501251163248L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 281, 26106170545821L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 283, 26604102257635L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 284, 29010182669624L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 285, 27412110150319L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 286, 25508111486644L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 287, 30010101882722L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 289, 29609191652827L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 290, 29906171167018L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 293, 27008262663545L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 296, 28703261733539L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 297, 29704192792019L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 298, 27601281095222L });

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumns: new[] { "Id", "NationalId" },
                keyValues: new object[] { 302, 26710060835422L });
        }
    }
}
