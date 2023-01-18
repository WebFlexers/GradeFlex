using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gradeflex.Data.Migrations
{
    /// <inheritdoc />
    public partial class CourseStudentDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoursesStudents",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 5 },
                    { 1, 13 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 27 },
                    { 1, 31 },
                    { 1, 45 },
                    { 2, 2 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 25 },
                    { 2, 29 },
                    { 2, 37 },
                    { 2, 46 },
                    { 3, 2 },
                    { 3, 19 },
                    { 3, 23 },
                    { 3, 25 },
                    { 3, 41 },
                    { 3, 47 },
                    { 4, 3 },
                    { 4, 9 },
                    { 4, 17 },
                    { 4, 22 },
                    { 4, 34 },
                    { 4, 43 },
                    { 4, 46 },
                    { 4, 47 },
                    { 5, 35 },
                    { 5, 36 },
                    { 5, 37 },
                    { 5, 41 },
                    { 5, 45 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 13 },
                    { 6, 17 },
                    { 6, 20 },
                    { 6, 29 },
                    { 6, 31 },
                    { 6, 36 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 8 },
                    { 7, 14 },
                    { 7, 15 },
                    { 7, 26 },
                    { 7, 30 },
                    { 7, 32 },
                    { 7, 48 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 24 },
                    { 8, 32 },
                    { 8, 42 },
                    { 9, 2 },
                    { 9, 9 },
                    { 9, 12 },
                    { 9, 13 },
                    { 9, 27 },
                    { 9, 34 },
                    { 9, 35 },
                    { 9, 37 },
                    { 9, 40 },
                    { 9, 45 },
                    { 9, 46 },
                    { 10, 12 },
                    { 10, 23 },
                    { 10, 47 },
                    { 11, 14 },
                    { 11, 16 },
                    { 11, 28 },
                    { 11, 32 },
                    { 11, 33 },
                    { 11, 38 },
                    { 11, 39 },
                    { 11, 42 },
                    { 12, 7 },
                    { 12, 16 },
                    { 12, 21 },
                    { 12, 39 },
                    { 12, 44 },
                    { 12, 49 },
                    { 13, 1 },
                    { 13, 6 },
                    { 13, 14 },
                    { 13, 15 },
                    { 13, 24 },
                    { 13, 26 },
                    { 13, 30 },
                    { 13, 44 },
                    { 14, 1 },
                    { 14, 4 },
                    { 14, 16 },
                    { 14, 38 },
                    { 14, 44 },
                    { 15, 3 },
                    { 15, 5 },
                    { 15, 18 },
                    { 15, 19 },
                    { 15, 20 },
                    { 15, 25 },
                    { 15, 31 },
                    { 15, 34 },
                    { 15, 35 },
                    { 15, 40 },
                    { 15, 43 },
                    { 16, 3 },
                    { 16, 9 },
                    { 16, 12 },
                    { 16, 22 },
                    { 16, 27 },
                    { 16, 29 },
                    { 16, 36 },
                    { 16, 40 },
                    { 16, 41 },
                    { 16, 43 },
                    { 17, 1 },
                    { 17, 6 },
                    { 17, 7 },
                    { 17, 11 },
                    { 17, 15 },
                    { 17, 33 },
                    { 18, 10 },
                    { 18, 11 },
                    { 18, 26 },
                    { 18, 33 },
                    { 18, 48 },
                    { 18, 49 },
                    { 19, 4 },
                    { 19, 7 },
                    { 19, 8 },
                    { 19, 10 },
                    { 19, 21 },
                    { 19, 28 },
                    { 19, 30 },
                    { 19, 42 },
                    { 20, 6 },
                    { 20, 8 },
                    { 20, 21 },
                    { 20, 24 },
                    { 20, 28 },
                    { 20, 38 },
                    { 20, 39 },
                    { 20, 48 },
                    { 20, 49 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 45 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 37 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 46 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 41 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 47 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 34 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 43 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 46 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 47 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 36 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 37 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 41 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 45 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 20 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 29 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 31 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 36 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 26 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 30 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 32 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 48 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 8, 24 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 8, 32 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 8, 42 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 27 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 34 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 35 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 37 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 40 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 45 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 9, 46 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 10, 23 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 10, 47 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 11, 28 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 11, 32 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 11, 33 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 11, 38 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 11, 39 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 11, 42 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 12, 21 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 12, 39 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 12, 44 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 12, 49 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 13, 24 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 13, 26 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 13, 30 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 13, 44 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 14, 16 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 14, 38 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 14, 44 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 18 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 19 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 20 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 25 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 31 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 34 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 35 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 40 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 15, 43 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 22 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 27 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 29 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 36 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 40 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 41 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 16, 43 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 17, 11 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 17, 15 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 17, 33 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 18, 11 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 18, 26 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 18, 33 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 18, 48 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 18, 49 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 19, 21 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 19, 28 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 19, 30 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 19, 42 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 20, 21 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 20, 24 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 20, 28 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 20, 38 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 20, 39 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 20, 48 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 20, 49 });
        }
    }
}
