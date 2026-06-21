using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutpatientClinicsComplex.Migrations
{
    /// <inheritdoc />
    public partial class datasetappointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AppointmentDate", "DoctorCode", "DurationMinutes", "EndTime", "PatientId", "PatientNationalId", "ReceptionistCode", "StartTime", "Status" },
                values: new object[,]
                {
                    { 1, new DateOnly(2025, 1, 21), 6, 15, new TimeOnly(0, 15, 0), 286, 27710080619122L, 2, new TimeOnly(0, 0, 0), "Completed" },
                    { 2, new DateOnly(2025, 3, 23), 6, 15, new TimeOnly(10, 15, 0), 306, 30003161277233L, 2, new TimeOnly(10, 0, 0), "Completed" },
                    { 3, new DateOnly(2025, 12, 23), 8, 15, new TimeOnly(0, 15, 0), 407, 30209252438214L, 3, new TimeOnly(0, 0, 0), "Completed" },
                    { 4, new DateOnly(2025, 2, 26), 2, 15, new TimeOnly(10, 15, 0), 75, 27207010318911L, 2, new TimeOnly(10, 0, 0), "Completed" },
                    { 5, new DateOnly(2025, 1, 23), 2, 15, new TimeOnly(10, 15, 0), 484, 28705190974544L, 1, new TimeOnly(10, 0, 0), "Scheduled" },
                    { 6, new DateOnly(2025, 11, 24), 1, 15, new TimeOnly(11, 15, 0), 327, 26304081958943L, 3, new TimeOnly(11, 0, 0), "Completed" },
                    { 7, new DateOnly(2025, 3, 1), 2, 15, new TimeOnly(12, 15, 0), 207, 25805240820423L, 2, new TimeOnly(12, 0, 0), "Completed" },
                    { 8, new DateOnly(2025, 12, 17), 5, 15, new TimeOnly(13, 15, 0), 373, 27210131964727L, 2, new TimeOnly(13, 0, 0), "Completed" },
                    { 9, new DateOnly(2025, 10, 30), 1, 15, new TimeOnly(14, 15, 0), 376, 27011140332648L, 3, new TimeOnly(14, 0, 0), "Scheduled" },
                    { 10, new DateOnly(2025, 4, 19), 2, 15, new TimeOnly(15, 15, 0), 245, 29209171077549L, 1, new TimeOnly(15, 0, 0), "Scheduled" },
                    { 11, new DateOnly(2025, 3, 1), 8, 15, new TimeOnly(16, 15, 0), 358, 30509241483728L, 1, new TimeOnly(16, 0, 0), "Completed" },
                    { 12, new DateOnly(2025, 4, 16), 5, 15, new TimeOnly(17, 15, 0), 383, 26703160859121L, 3, new TimeOnly(17, 0, 0), "Completed" },
                    { 13, new DateOnly(2025, 5, 12), 3, 15, new TimeOnly(18, 15, 0), 266, 26703070444031L, 1, new TimeOnly(18, 0, 0), "Scheduled" },
                    { 14, new DateOnly(2025, 4, 15), 6, 15, new TimeOnly(19, 15, 0), 263, 30111041134926L, 1, new TimeOnly(19, 0, 0), "Cancelled" },
                    { 15, new DateOnly(2025, 10, 19), 1, 15, new TimeOnly(20, 15, 0), 470, 28712041974029L, 2, new TimeOnly(20, 0, 0), "Scheduled" },
                    { 16, new DateOnly(2025, 2, 7), 6, 15, new TimeOnly(21, 15, 0), 69, 26911102765112L, 3, new TimeOnly(21, 0, 0), "Completed" },
                    { 17, new DateOnly(2025, 6, 30), 2, 15, new TimeOnly(22, 15, 0), 491, 29307172516614L, 1, new TimeOnly(22, 0, 0), "Completed" },
                    { 18, new DateOnly(2025, 10, 5), 8, 15, new TimeOnly(23, 15, 0), 303, 29208111352836L, 1, new TimeOnly(23, 0, 0), "Completed" },
                    { 19, new DateOnly(2025, 1, 2), 7, 15, new TimeOnly(0, 15, 0), 47, 29706140775021L, 3, new TimeOnly(0, 0, 0), "Completed" },
                    { 20, new DateOnly(2025, 1, 22), 2, 15, new TimeOnly(1, 15, 0), 159, 27001270195412L, 2, new TimeOnly(1, 0, 0), "Scheduled" },
                    { 21, new DateOnly(2025, 9, 20), 6, 15, new TimeOnly(2, 15, 0), 368, 28810112499039L, 2, new TimeOnly(2, 0, 0), "Scheduled" },
                    { 22, new DateOnly(2025, 12, 20), 1, 15, new TimeOnly(3, 15, 0), 118, 27902182124842L, 1, new TimeOnly(3, 0, 0), "Completed" },
                    { 23, new DateOnly(2025, 2, 5), 1, 15, new TimeOnly(4, 15, 0), 411, 29010182669624L, 3, new TimeOnly(4, 0, 0), "Scheduled" },
                    { 24, new DateOnly(2025, 8, 31), 1, 15, new TimeOnly(5, 15, 0), 45, 29509201483533L, 2, new TimeOnly(5, 0, 0), "Completed" },
                    { 25, new DateOnly(2025, 11, 20), 8, 15, new TimeOnly(6, 15, 0), 343, 30302121229811L, 1, new TimeOnly(6, 0, 0), "Completed" },
                    { 26, new DateOnly(2025, 5, 19), 2, 15, new TimeOnly(7, 15, 0), 252, 30411061042648L, 1, new TimeOnly(7, 0, 0), "Cancelled" },
                    { 27, new DateOnly(2025, 3, 8), 3, 15, new TimeOnly(8, 15, 0), 344, 26201162360735L, 2, new TimeOnly(8, 0, 0), "Scheduled" },
                    { 28, new DateOnly(2025, 12, 11), 6, 15, new TimeOnly(9, 15, 0), 413, 28606281562033L, 3, new TimeOnly(9, 0, 0), "Cancelled" },
                    { 29, new DateOnly(2025, 4, 23), 2, 15, new TimeOnly(10, 15, 0), 489, 26011271939936L, 1, new TimeOnly(10, 0, 0), "Scheduled" },
                    { 30, new DateOnly(2025, 7, 12), 1, 15, new TimeOnly(11, 15, 0), 290, 28405040354337L, 1, new TimeOnly(11, 0, 0), "Completed" },
                    { 31, new DateOnly(2025, 2, 1), 1, 15, new TimeOnly(12, 15, 0), 403, 26007120337426L, 3, new TimeOnly(12, 0, 0), "Scheduled" },
                    { 32, new DateOnly(2025, 2, 20), 1, 15, new TimeOnly(13, 15, 0), 138, 27210091522045L, 2, new TimeOnly(13, 0, 0), "Scheduled" },
                    { 33, new DateOnly(2025, 3, 12), 3, 15, new TimeOnly(14, 15, 0), 277, 27302092052212L, 3, new TimeOnly(14, 0, 0), "Completed" },
                    { 34, new DateOnly(2025, 5, 4), 2, 15, new TimeOnly(15, 15, 0), 189, 29908282553214L, 2, new TimeOnly(15, 0, 0), "Completed" },
                    { 35, new DateOnly(2025, 2, 10), 2, 15, new TimeOnly(16, 15, 0), 445, 26603232370334L, 3, new TimeOnly(16, 0, 0), "Completed" },
                    { 36, new DateOnly(2025, 1, 20), 1, 15, new TimeOnly(17, 15, 0), 138, 27210091522045L, 2, new TimeOnly(17, 0, 0), "Cancelled" },
                    { 37, new DateOnly(2025, 1, 28), 1, 15, new TimeOnly(18, 15, 0), 351, 28010032251413L, 3, new TimeOnly(18, 0, 0), "Completed" },
                    { 38, new DateOnly(2025, 2, 14), 5, 15, new TimeOnly(19, 15, 0), 170, 29704262256412L, 2, new TimeOnly(19, 0, 0), "Completed" },
                    { 39, new DateOnly(2025, 11, 20), 6, 15, new TimeOnly(20, 15, 0), 304, 27503110764434L, 2, new TimeOnly(20, 0, 0), "Completed" },
                    { 40, new DateOnly(2025, 7, 23), 2, 15, new TimeOnly(21, 15, 0), 371, 26802200544638L, 2, new TimeOnly(21, 0, 0), "Cancelled" },
                    { 41, new DateOnly(2025, 12, 4), 1, 15, new TimeOnly(22, 15, 0), 329, 27307081432343L, 3, new TimeOnly(22, 0, 0), "Scheduled" },
                    { 42, new DateOnly(2025, 11, 23), 6, 15, new TimeOnly(23, 15, 0), 333, 28103171378429L, 3, new TimeOnly(23, 0, 0), "Completed" },
                    { 43, new DateOnly(2025, 5, 5), 7, 15, new TimeOnly(0, 15, 0), 336, 29707182119014L, 2, new TimeOnly(0, 0, 0), "Scheduled" },
                    { 44, new DateOnly(2025, 9, 2), 4, 15, new TimeOnly(1, 15, 0), 206, 29903171168426L, 3, new TimeOnly(1, 0, 0), "Completed" },
                    { 45, new DateOnly(2025, 1, 23), 3, 15, new TimeOnly(2, 15, 0), 457, 28612021557035L, 1, new TimeOnly(2, 0, 0), "Completed" },
                    { 46, new DateOnly(2025, 5, 16), 6, 15, new TimeOnly(3, 15, 0), 333, 28103171378429L, 3, new TimeOnly(3, 0, 0), "Completed" },
                    { 47, new DateOnly(2025, 12, 2), 2, 15, new TimeOnly(4, 15, 0), 285, 30512242187043L, 2, new TimeOnly(4, 0, 0), "Completed" },
                    { 48, new DateOnly(2025, 1, 13), 8, 15, new TimeOnly(5, 15, 0), 347, 29409112072647L, 1, new TimeOnly(5, 0, 0), "Completed" },
                    { 49, new DateOnly(2025, 12, 25), 1, 15, new TimeOnly(6, 15, 0), 118, 27902182124842L, 3, new TimeOnly(6, 0, 0), "Completed" },
                    { 50, new DateOnly(2025, 1, 18), 2, 15, new TimeOnly(7, 15, 0), 251, 27807060786621L, 1, new TimeOnly(7, 0, 0), "Completed" },
                    { 51, new DateOnly(2025, 2, 24), 4, 15, new TimeOnly(8, 15, 0), 481, 27105110133048L, 1, new TimeOnly(8, 0, 0), "Completed" },
                    { 52, new DateOnly(2025, 3, 31), 8, 15, new TimeOnly(9, 15, 0), 409, 25911201723239L, 3, new TimeOnly(9, 0, 0), "Scheduled" },
                    { 53, new DateOnly(2025, 6, 25), 2, 15, new TimeOnly(10, 15, 0), 25, 28712250827841L, 1, new TimeOnly(10, 0, 0), "Completed" },
                    { 54, new DateOnly(2025, 9, 24), 3, 15, new TimeOnly(11, 15, 0), 83, 28710042492533L, 3, new TimeOnly(11, 0, 0), "Completed" },
                    { 55, new DateOnly(2025, 1, 20), 6, 15, new TimeOnly(12, 15, 0), 263, 30111041134926L, 1, new TimeOnly(12, 0, 0), "Completed" },
                    { 56, new DateOnly(2025, 4, 7), 8, 15, new TimeOnly(13, 15, 0), 363, 29405131845932L, 3, new TimeOnly(13, 0, 0), "Completed" },
                    { 57, new DateOnly(2025, 12, 17), 6, 15, new TimeOnly(14, 15, 0), 396, 30112210159635L, 2, new TimeOnly(14, 0, 0), "Scheduled" },
                    { 58, new DateOnly(2025, 10, 7), 5, 15, new TimeOnly(15, 15, 0), 13, 26209180710143L, 3, new TimeOnly(15, 0, 0), "Completed" },
                    { 59, new DateOnly(2025, 12, 31), 2, 15, new TimeOnly(16, 15, 0), 233, 27511240884043L, 3, new TimeOnly(16, 0, 0), "Completed" },
                    { 60, new DateOnly(2025, 6, 1), 8, 15, new TimeOnly(17, 15, 0), 146, 28605141565945L, 2, new TimeOnly(17, 0, 0), "Completed" },
                    { 61, new DateOnly(2025, 1, 26), 8, 15, new TimeOnly(18, 15, 0), 453, 26509130297918L, 2, new TimeOnly(18, 0, 0), "Scheduled" },
                    { 62, new DateOnly(2025, 1, 19), 3, 15, new TimeOnly(19, 15, 0), 320, 28310120163531L, 2, new TimeOnly(19, 0, 0), "Completed" },
                    { 63, new DateOnly(2025, 2, 2), 8, 15, new TimeOnly(20, 15, 0), 352, 25508111486644L, 2, new TimeOnly(20, 0, 0), "Completed" },
                    { 64, new DateOnly(2025, 2, 3), 1, 15, new TimeOnly(21, 15, 0), 60, 26601240218847L, 2, new TimeOnly(21, 0, 0), "Scheduled" },
                    { 65, new DateOnly(2025, 6, 13), 2, 15, new TimeOnly(22, 15, 0), 72, 29606190935334L, 1, new TimeOnly(22, 0, 0), "Completed" },
                    { 66, new DateOnly(2025, 3, 24), 1, 15, new TimeOnly(23, 15, 0), 423, 26604102257635L, 2, new TimeOnly(23, 0, 0), "Completed" },
                    { 67, new DateOnly(2025, 3, 25), 4, 15, new TimeOnly(0, 15, 0), 80, 27708250891123L, 2, new TimeOnly(0, 0, 0), "Completed" },
                    { 68, new DateOnly(2025, 9, 10), 8, 15, new TimeOnly(1, 15, 0), 312, 29011272346948L, 2, new TimeOnly(1, 0, 0), "Completed" },
                    { 69, new DateOnly(2025, 1, 27), 2, 15, new TimeOnly(2, 15, 0), 421, 28101151960738L, 1, new TimeOnly(2, 0, 0), "Completed" },
                    { 70, new DateOnly(2025, 2, 9), 8, 15, new TimeOnly(3, 15, 0), 454, 29602061327126L, 2, new TimeOnly(3, 0, 0), "Completed" },
                    { 71, new DateOnly(2025, 7, 23), 5, 15, new TimeOnly(4, 15, 0), 89, 25906261624719L, 1, new TimeOnly(4, 0, 0), "Completed" },
                    { 72, new DateOnly(2025, 2, 24), 1, 15, new TimeOnly(5, 15, 0), 5, 26003102010546L, 3, new TimeOnly(5, 0, 0), "Completed" },
                    { 73, new DateOnly(2025, 8, 20), 3, 15, new TimeOnly(6, 15, 0), 224, 26209250732445L, 1, new TimeOnly(6, 0, 0), "Completed" },
                    { 74, new DateOnly(2025, 9, 8), 7, 15, new TimeOnly(7, 15, 0), 485, 29606011937936L, 3, new TimeOnly(7, 0, 0), "Completed" },
                    { 75, new DateOnly(2025, 3, 26), 3, 15, new TimeOnly(8, 15, 0), 224, 26209250732445L, 3, new TimeOnly(8, 0, 0), "Scheduled" },
                    { 76, new DateOnly(2025, 11, 25), 7, 15, new TimeOnly(9, 15, 0), 278, 29508250646133L, 1, new TimeOnly(9, 0, 0), "Scheduled" },
                    { 77, new DateOnly(2025, 3, 26), 1, 15, new TimeOnly(10, 15, 0), 180, 25501131084424L, 2, new TimeOnly(10, 0, 0), "Completed" },
                    { 78, new DateOnly(2025, 3, 18), 5, 15, new TimeOnly(11, 15, 0), 311, 29602101223226L, 1, new TimeOnly(11, 0, 0), "Completed" },
                    { 79, new DateOnly(2025, 12, 12), 4, 15, new TimeOnly(12, 15, 0), 469, 30010101882722L, 1, new TimeOnly(12, 0, 0), "Completed" },
                    { 80, new DateOnly(2025, 9, 13), 4, 15, new TimeOnly(13, 15, 0), 342, 25707260961746L, 3, new TimeOnly(13, 0, 0), "Scheduled" },
                    { 81, new DateOnly(2025, 11, 22), 4, 15, new TimeOnly(14, 15, 0), 317, 26712172611438L, 1, new TimeOnly(14, 0, 0), "Completed" },
                    { 82, new DateOnly(2025, 5, 25), 3, 15, new TimeOnly(15, 15, 0), 332, 27306201560027L, 2, new TimeOnly(15, 0, 0), "Completed" },
                    { 83, new DateOnly(2025, 4, 7), 8, 15, new TimeOnly(16, 15, 0), 35, 28309012086142L, 1, new TimeOnly(16, 0, 0), "Completed" },
                    { 84, new DateOnly(2025, 7, 13), 4, 15, new TimeOnly(17, 15, 0), 498, 27010030881513L, 2, new TimeOnly(17, 0, 0), "Scheduled" },
                    { 85, new DateOnly(2025, 12, 4), 2, 15, new TimeOnly(18, 15, 0), 371, 26802200544638L, 2, new TimeOnly(18, 0, 0), "Completed" },
                    { 86, new DateOnly(2025, 12, 12), 2, 15, new TimeOnly(19, 15, 0), 234, 27707162418322L, 2, new TimeOnly(19, 0, 0), "Cancelled" },
                    { 87, new DateOnly(2025, 4, 17), 8, 15, new TimeOnly(20, 15, 0), 372, 29901190376634L, 2, new TimeOnly(20, 0, 0), "Cancelled" },
                    { 88, new DateOnly(2025, 6, 27), 5, 15, new TimeOnly(21, 15, 0), 172, 25501032488425L, 1, new TimeOnly(21, 0, 0), "Cancelled" },
                    { 89, new DateOnly(2025, 1, 23), 3, 15, new TimeOnly(22, 15, 0), 139, 26204021610825L, 2, new TimeOnly(22, 0, 0), "Completed" },
                    { 90, new DateOnly(2025, 1, 17), 2, 15, new TimeOnly(23, 15, 0), 468, 28507011226947L, 1, new TimeOnly(23, 0, 0), "Cancelled" },
                    { 91, new DateOnly(2025, 10, 8), 3, 15, new TimeOnly(0, 15, 0), 455, 26512100991915L, 3, new TimeOnly(0, 0, 0), "Completed" },
                    { 92, new DateOnly(2025, 1, 24), 4, 15, new TimeOnly(1, 15, 0), 175, 30406152649934L, 3, new TimeOnly(1, 0, 0), "Completed" },
                    { 93, new DateOnly(2025, 10, 31), 8, 15, new TimeOnly(2, 15, 0), 347, 29409112072647L, 3, new TimeOnly(2, 0, 0), "Completed" },
                    { 94, new DateOnly(2025, 10, 15), 6, 15, new TimeOnly(3, 15, 0), 7, 26405060651914L, 1, new TimeOnly(3, 0, 0), "Scheduled" },
                    { 95, new DateOnly(2025, 10, 23), 4, 15, new TimeOnly(4, 15, 0), 243, 28004091523821L, 3, new TimeOnly(4, 0, 0), "Completed" },
                    { 96, new DateOnly(2025, 8, 30), 7, 15, new TimeOnly(5, 15, 0), 404, 26504110427215L, 1, new TimeOnly(5, 0, 0), "Completed" },
                    { 97, new DateOnly(2025, 7, 6), 6, 15, new TimeOnly(6, 15, 0), 122, 29907260215819L, 2, new TimeOnly(6, 0, 0), "Completed" },
                    { 98, new DateOnly(2025, 9, 22), 3, 15, new TimeOnly(7, 15, 0), 319, 28101061646726L, 2, new TimeOnly(7, 0, 0), "Scheduled" },
                    { 99, new DateOnly(2025, 12, 22), 1, 15, new TimeOnly(8, 15, 0), 163, 25910191374939L, 2, new TimeOnly(8, 0, 0), "Completed" },
                    { 100, new DateOnly(2025, 4, 9), 8, 15, new TimeOnly(9, 15, 0), 388, 29902221029018L, 3, new TimeOnly(9, 0, 0), "Cancelled" },
                    { 101, new DateOnly(2025, 12, 29), 2, 15, new TimeOnly(10, 15, 0), 484, 28705190974544L, 3, new TimeOnly(10, 0, 0), "Completed" },
                    { 102, new DateOnly(2025, 2, 6), 3, 15, new TimeOnly(11, 15, 0), 379, 29411140287447L, 2, new TimeOnly(11, 0, 0), "Completed" },
                    { 103, new DateOnly(2025, 4, 8), 8, 15, new TimeOnly(12, 15, 0), 309, 29301211810425L, 2, new TimeOnly(12, 0, 0), "Completed" },
                    { 104, new DateOnly(2025, 9, 5), 2, 15, new TimeOnly(13, 15, 0), 233, 27511240884043L, 2, new TimeOnly(13, 0, 0), "Cancelled" },
                    { 105, new DateOnly(2025, 11, 24), 2, 15, new TimeOnly(14, 15, 0), 234, 27707162418322L, 3, new TimeOnly(14, 0, 0), "Completed" },
                    { 106, new DateOnly(2025, 7, 21), 3, 15, new TimeOnly(15, 15, 0), 71, 30203062369321L, 1, new TimeOnly(15, 0, 0), "Completed" },
                    { 107, new DateOnly(2025, 2, 28), 2, 15, new TimeOnly(16, 15, 0), 301, 25705061032833L, 1, new TimeOnly(16, 0, 0), "Completed" },
                    { 108, new DateOnly(2025, 1, 10), 5, 15, new TimeOnly(17, 15, 0), 383, 26703160859121L, 2, new TimeOnly(17, 0, 0), "Completed" },
                    { 109, new DateOnly(2025, 7, 6), 8, 15, new TimeOnly(18, 15, 0), 347, 29409112072647L, 2, new TimeOnly(18, 0, 0), "Completed" },
                    { 110, new DateOnly(2025, 9, 5), 7, 15, new TimeOnly(19, 15, 0), 497, 25710272789132L, 1, new TimeOnly(19, 0, 0), "Completed" },
                    { 111, new DateOnly(2025, 5, 11), 2, 15, new TimeOnly(20, 15, 0), 490, 26504040445649L, 1, new TimeOnly(20, 0, 0), "Completed" },
                    { 112, new DateOnly(2025, 3, 6), 1, 15, new TimeOnly(21, 15, 0), 123, 30306030423845L, 3, new TimeOnly(21, 0, 0), "Cancelled" },
                    { 113, new DateOnly(2025, 11, 24), 6, 15, new TimeOnly(22, 15, 0), 275, 29709171562135L, 1, new TimeOnly(22, 0, 0), "Completed" },
                    { 114, new DateOnly(2025, 8, 19), 2, 15, new TimeOnly(23, 15, 0), 114, 26202071747247L, 2, new TimeOnly(23, 0, 0), "Scheduled" },
                    { 115, new DateOnly(2025, 6, 4), 5, 15, new TimeOnly(0, 15, 0), 356, 26210200423442L, 1, new TimeOnly(0, 0, 0), "Completed" },
                    { 116, new DateOnly(2025, 3, 20), 4, 15, new TimeOnly(1, 15, 0), 478, 28109171082233L, 3, new TimeOnly(1, 0, 0), "Scheduled" },
                    { 117, new DateOnly(2025, 8, 16), 8, 15, new TimeOnly(2, 15, 0), 171, 26902091750426L, 3, new TimeOnly(2, 0, 0), "Completed" },
                    { 118, new DateOnly(2025, 5, 11), 7, 15, new TimeOnly(3, 15, 0), 88, 26810030349019L, 1, new TimeOnly(3, 0, 0), "Cancelled" },
                    { 119, new DateOnly(2025, 2, 21), 8, 15, new TimeOnly(4, 15, 0), 303, 29208111352836L, 2, new TimeOnly(4, 0, 0), "Completed" },
                    { 120, new DateOnly(2025, 2, 7), 8, 15, new TimeOnly(5, 15, 0), 220, 25809132024142L, 2, new TimeOnly(5, 0, 0), "Completed" },
                    { 121, new DateOnly(2025, 5, 26), 6, 15, new TimeOnly(6, 15, 0), 122, 29907260215819L, 3, new TimeOnly(6, 0, 0), "Completed" },
                    { 122, new DateOnly(2025, 8, 8), 4, 15, new TimeOnly(7, 15, 0), 474, 28406122061644L, 3, new TimeOnly(7, 0, 0), "Completed" },
                    { 123, new DateOnly(2025, 3, 17), 1, 15, new TimeOnly(8, 15, 0), 162, 29907180467736L, 2, new TimeOnly(8, 0, 0), "Completed" },
                    { 124, new DateOnly(2025, 10, 13), 3, 15, new TimeOnly(9, 15, 0), 455, 26512100991915L, 3, new TimeOnly(9, 0, 0), "Completed" },
                    { 125, new DateOnly(2025, 10, 3), 7, 15, new TimeOnly(10, 15, 0), 63, 26206160149046L, 3, new TimeOnly(10, 0, 0), "Completed" },
                    { 126, new DateOnly(2025, 4, 29), 4, 15, new TimeOnly(11, 15, 0), 395, 29902021581915L, 2, new TimeOnly(11, 0, 0), "Completed" },
                    { 127, new DateOnly(2025, 5, 22), 2, 15, new TimeOnly(12, 15, 0), 189, 29908282553214L, 1, new TimeOnly(12, 0, 0), "Scheduled" },
                    { 128, new DateOnly(2025, 3, 7), 6, 15, new TimeOnly(13, 15, 0), 310, 29104150934231L, 3, new TimeOnly(13, 0, 0), "Completed" },
                    { 129, new DateOnly(2025, 5, 22), 5, 15, new TimeOnly(14, 15, 0), 265, 29609181438041L, 2, new TimeOnly(14, 0, 0), "Scheduled" },
                    { 130, new DateOnly(2025, 2, 16), 5, 15, new TimeOnly(15, 15, 0), 68, 27812230127946L, 3, new TimeOnly(15, 0, 0), "Cancelled" },
                    { 131, new DateOnly(2025, 12, 4), 1, 15, new TimeOnly(16, 15, 0), 196, 27212100555541L, 3, new TimeOnly(16, 0, 0), "Completed" },
                    { 132, new DateOnly(2025, 6, 16), 8, 15, new TimeOnly(17, 15, 0), 307, 29110192631047L, 1, new TimeOnly(17, 0, 0), "Scheduled" },
                    { 133, new DateOnly(2025, 8, 20), 5, 15, new TimeOnly(18, 15, 0), 287, 25910271883016L, 2, new TimeOnly(18, 0, 0), "Completed" },
                    { 134, new DateOnly(2025, 2, 17), 5, 15, new TimeOnly(19, 15, 0), 24, 29706262713545L, 3, new TimeOnly(19, 0, 0), "Completed" },
                    { 135, new DateOnly(2025, 2, 21), 1, 15, new TimeOnly(20, 15, 0), 223, 27905010710646L, 2, new TimeOnly(20, 0, 0), "Completed" },
                    { 136, new DateOnly(2025, 4, 3), 2, 15, new TimeOnly(21, 15, 0), 42, 30502011419048L, 2, new TimeOnly(21, 0, 0), "Completed" },
                    { 137, new DateOnly(2025, 11, 16), 3, 15, new TimeOnly(22, 15, 0), 277, 27302092052212L, 1, new TimeOnly(22, 0, 0), "Scheduled" },
                    { 138, new DateOnly(2025, 6, 4), 4, 15, new TimeOnly(23, 15, 0), 198, 27102181731443L, 1, new TimeOnly(23, 0, 0), "Cancelled" },
                    { 139, new DateOnly(2025, 10, 24), 8, 15, new TimeOnly(0, 15, 0), 312, 29011272346948L, 2, new TimeOnly(0, 0, 0), "Completed" },
                    { 140, new DateOnly(2025, 1, 27), 6, 15, new TimeOnly(1, 15, 0), 181, 26705181427449L, 1, new TimeOnly(1, 0, 0), "Completed" },
                    { 141, new DateOnly(2025, 7, 24), 1, 15, new TimeOnly(2, 15, 0), 429, 27603032453425L, 1, new TimeOnly(2, 0, 0), "Completed" },
                    { 142, new DateOnly(2025, 11, 8), 2, 15, new TimeOnly(3, 15, 0), 384, 26501251163248L, 3, new TimeOnly(3, 0, 0), "Completed" },
                    { 143, new DateOnly(2025, 11, 16), 8, 15, new TimeOnly(4, 15, 0), 427, 28606280831448L, 3, new TimeOnly(4, 0, 0), "Completed" },
                    { 144, new DateOnly(2025, 4, 24), 4, 15, new TimeOnly(5, 15, 0), 296, 30312031681246L, 1, new TimeOnly(5, 0, 0), "Completed" },
                    { 145, new DateOnly(2025, 12, 12), 4, 15, new TimeOnly(6, 15, 0), 325, 28908152583844L, 1, new TimeOnly(6, 0, 0), "Completed" },
                    { 146, new DateOnly(2025, 1, 2), 8, 15, new TimeOnly(7, 15, 0), 303, 29208111352836L, 3, new TimeOnly(7, 0, 0), "Completed" },
                    { 147, new DateOnly(2025, 5, 6), 4, 15, new TimeOnly(8, 15, 0), 469, 30010101882722L, 1, new TimeOnly(8, 0, 0), "Completed" },
                    { 148, new DateOnly(2025, 5, 9), 2, 15, new TimeOnly(9, 15, 0), 301, 25705061032833L, 2, new TimeOnly(9, 0, 0), "Completed" },
                    { 149, new DateOnly(2025, 1, 3), 4, 15, new TimeOnly(10, 15, 0), 471, 26501201167834L, 3, new TimeOnly(10, 0, 0), "Scheduled" },
                    { 150, new DateOnly(2025, 12, 9), 8, 15, new TimeOnly(11, 15, 0), 145, 29604192279134L, 1, new TimeOnly(11, 0, 0), "Completed" },
                    { 151, new DateOnly(2025, 6, 8), 7, 15, new TimeOnly(12, 15, 0), 404, 26504110427215L, 3, new TimeOnly(12, 0, 0), "Completed" },
                    { 152, new DateOnly(2025, 12, 27), 8, 15, new TimeOnly(13, 15, 0), 312, 29011272346948L, 1, new TimeOnly(13, 0, 0), "Completed" },
                    { 153, new DateOnly(2025, 7, 29), 6, 15, new TimeOnly(14, 15, 0), 275, 29709171562135L, 1, new TimeOnly(14, 0, 0), "Completed" },
                    { 154, new DateOnly(2025, 6, 13), 2, 15, new TimeOnly(15, 15, 0), 484, 28705190974544L, 3, new TimeOnly(15, 0, 0), "Completed" },
                    { 155, new DateOnly(2025, 10, 25), 6, 15, new TimeOnly(16, 15, 0), 258, 26508222186144L, 3, new TimeOnly(16, 0, 0), "Completed" },
                    { 156, new DateOnly(2025, 5, 4), 7, 15, new TimeOnly(17, 15, 0), 150, 29604230552116L, 3, new TimeOnly(17, 0, 0), "Completed" },
                    { 157, new DateOnly(2025, 12, 27), 7, 15, new TimeOnly(18, 15, 0), 485, 29606011937936L, 3, new TimeOnly(18, 0, 0), "Completed" },
                    { 158, new DateOnly(2025, 6, 25), 2, 15, new TimeOnly(19, 15, 0), 159, 27001270195412L, 3, new TimeOnly(19, 0, 0), "Completed" },
                    { 159, new DateOnly(2025, 8, 21), 3, 15, new TimeOnly(20, 15, 0), 135, 28208070953031L, 1, new TimeOnly(20, 0, 0), "Scheduled" },
                    { 160, new DateOnly(2025, 2, 20), 8, 15, new TimeOnly(21, 15, 0), 73, 29510220742437L, 2, new TimeOnly(21, 0, 0), "Completed" },
                    { 161, new DateOnly(2025, 6, 7), 5, 15, new TimeOnly(22, 15, 0), 316, 26110032684141L, 1, new TimeOnly(22, 0, 0), "Scheduled" },
                    { 162, new DateOnly(2025, 9, 6), 3, 15, new TimeOnly(23, 15, 0), 262, 28109140485342L, 1, new TimeOnly(23, 0, 0), "Completed" },
                    { 163, new DateOnly(2025, 6, 26), 1, 15, new TimeOnly(0, 15, 0), 353, 27304051311349L, 1, new TimeOnly(0, 0, 0), "Scheduled" },
                    { 164, new DateOnly(2025, 9, 2), 6, 15, new TimeOnly(1, 15, 0), 391, 27601281095222L, 2, new TimeOnly(1, 0, 0), "Completed" },
                    { 165, new DateOnly(2025, 3, 16), 6, 15, new TimeOnly(2, 15, 0), 298, 27003251965448L, 1, new TimeOnly(2, 0, 0), "Completed" },
                    { 166, new DateOnly(2025, 3, 22), 7, 15, new TimeOnly(3, 15, 0), 85, 27804052712418L, 2, new TimeOnly(3, 0, 0), "Completed" },
                    { 167, new DateOnly(2025, 1, 1), 7, 15, new TimeOnly(4, 15, 0), 150, 29604230552116L, 2, new TimeOnly(4, 0, 0), "Completed" },
                    { 168, new DateOnly(2025, 12, 21), 6, 15, new TimeOnly(5, 15, 0), 32, 25606111335012L, 2, new TimeOnly(5, 0, 0), "Completed" },
                    { 169, new DateOnly(2025, 9, 20), 6, 15, new TimeOnly(6, 15, 0), 304, 27503110764434L, 3, new TimeOnly(6, 0, 0), "Completed" },
                    { 170, new DateOnly(2025, 11, 18), 3, 15, new TimeOnly(7, 15, 0), 448, 27906061966143L, 1, new TimeOnly(7, 0, 0), "Completed" },
                    { 171, new DateOnly(2025, 3, 24), 1, 15, new TimeOnly(8, 15, 0), 226, 26812252287219L, 1, new TimeOnly(8, 0, 0), "Completed" },
                    { 172, new DateOnly(2025, 10, 10), 7, 15, new TimeOnly(9, 15, 0), 336, 29707182119014L, 3, new TimeOnly(9, 0, 0), "Scheduled" },
                    { 173, new DateOnly(2025, 12, 10), 3, 15, new TimeOnly(10, 15, 0), 283, 29402051031646L, 2, new TimeOnly(10, 0, 0), "Completed" },
                    { 174, new DateOnly(2025, 7, 29), 5, 15, new TimeOnly(11, 15, 0), 68, 27812230127946L, 3, new TimeOnly(11, 0, 0), "Completed" },
                    { 175, new DateOnly(2025, 6, 13), 5, 15, new TimeOnly(12, 15, 0), 155, 27204041387323L, 1, new TimeOnly(12, 0, 0), "Scheduled" },
                    { 176, new DateOnly(2025, 11, 19), 2, 15, new TimeOnly(13, 15, 0), 112, 26101111663415L, 1, new TimeOnly(13, 0, 0), "Completed" },
                    { 177, new DateOnly(2025, 7, 8), 7, 15, new TimeOnly(14, 15, 0), 182, 28504151321419L, 2, new TimeOnly(14, 0, 0), "Completed" },
                    { 178, new DateOnly(2025, 1, 6), 3, 15, new TimeOnly(15, 15, 0), 392, 30312031327335L, 2, new TimeOnly(15, 0, 0), "Completed" },
                    { 179, new DateOnly(2025, 12, 18), 1, 15, new TimeOnly(16, 15, 0), 327, 26304081958943L, 2, new TimeOnly(16, 0, 0), "Cancelled" },
                    { 180, new DateOnly(2025, 1, 12), 8, 15, new TimeOnly(17, 15, 0), 50, 27007171823145L, 3, new TimeOnly(17, 0, 0), "Completed" },
                    { 181, new DateOnly(2025, 4, 30), 8, 15, new TimeOnly(18, 15, 0), 409, 25911201723239L, 2, new TimeOnly(18, 0, 0), "Completed" },
                    { 182, new DateOnly(2025, 1, 21), 1, 15, new TimeOnly(19, 15, 0), 136, 28502111480343L, 1, new TimeOnly(19, 0, 0), "Completed" },
                    { 183, new DateOnly(2025, 10, 11), 4, 15, new TimeOnly(20, 15, 0), 292, 26201062453818L, 1, new TimeOnly(20, 0, 0), "Completed" },
                    { 184, new DateOnly(2025, 11, 23), 1, 15, new TimeOnly(21, 15, 0), 168, 26103191967218L, 3, new TimeOnly(21, 0, 0), "Completed" },
                    { 185, new DateOnly(2025, 10, 29), 3, 15, new TimeOnly(22, 15, 0), 66, 27301211520721L, 1, new TimeOnly(22, 0, 0), "Scheduled" },
                    { 186, new DateOnly(2025, 11, 3), 6, 15, new TimeOnly(23, 15, 0), 188, 26711271888735L, 3, new TimeOnly(23, 0, 0), "Cancelled" },
                    { 187, new DateOnly(2025, 3, 25), 6, 15, new TimeOnly(0, 15, 0), 23, 27403050139245L, 1, new TimeOnly(0, 0, 0), "Completed" },
                    { 188, new DateOnly(2025, 12, 15), 4, 15, new TimeOnly(1, 15, 0), 433, 29001230483217L, 2, new TimeOnly(1, 0, 0), "Cancelled" },
                    { 189, new DateOnly(2025, 12, 9), 3, 15, new TimeOnly(2, 15, 0), 266, 26703070444031L, 1, new TimeOnly(2, 0, 0), "Completed" },
                    { 190, new DateOnly(2025, 1, 27), 2, 15, new TimeOnly(3, 15, 0), 490, 26504040445649L, 3, new TimeOnly(3, 0, 0), "Completed" },
                    { 191, new DateOnly(2025, 12, 19), 2, 15, new TimeOnly(4, 15, 0), 238, 29805050237031L, 1, new TimeOnly(4, 0, 0), "Scheduled" },
                    { 192, new DateOnly(2025, 10, 22), 1, 15, new TimeOnly(5, 15, 0), 22, 30510280399723L, 1, new TimeOnly(5, 0, 0), "Cancelled" },
                    { 193, new DateOnly(2025, 3, 11), 5, 15, new TimeOnly(6, 15, 0), 314, 25912080397728L, 3, new TimeOnly(6, 0, 0), "Completed" },
                    { 194, new DateOnly(2025, 12, 23), 4, 15, new TimeOnly(7, 15, 0), 239, 29205121611912L, 1, new TimeOnly(7, 0, 0), "Completed" },
                    { 195, new DateOnly(2025, 10, 15), 4, 15, new TimeOnly(8, 15, 0), 202, 25802082334821L, 1, new TimeOnly(8, 0, 0), "Completed" },
                    { 196, new DateOnly(2025, 10, 6), 7, 15, new TimeOnly(9, 15, 0), 185, 30412130970331L, 2, new TimeOnly(9, 0, 0), "Completed" },
                    { 197, new DateOnly(2025, 9, 14), 6, 15, new TimeOnly(10, 15, 0), 156, 26808032624412L, 2, new TimeOnly(10, 0, 0), "Completed" },
                    { 198, new DateOnly(2025, 1, 13), 3, 15, new TimeOnly(11, 15, 0), 174, 30311020977349L, 3, new TimeOnly(11, 0, 0), "Completed" },
                    { 199, new DateOnly(2025, 1, 24), 2, 15, new TimeOnly(12, 15, 0), 167, 26101261141815L, 2, new TimeOnly(12, 0, 0), "Completed" },
                    { 200, new DateOnly(2025, 11, 3), 5, 15, new TimeOnly(13, 15, 0), 311, 29602101223226L, 1, new TimeOnly(13, 0, 0), "Completed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}
