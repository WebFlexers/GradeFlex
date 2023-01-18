using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gradeflex.Data.Migrations
{
    /// <inheritdoc />
    public partial class CourseDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "ProfessorId", "Semester", "Title" },
                values: new object[,]
                {
                    { 1, 1, "5", "Databases and modeling" },
                    { 2, 1, "7", "Analysis of biological sequences and structures" },
                    { 3, 2, "7", "Introduction to Systems Development" },
                    { 4, 2, "4", "Concurrent programming" },
                    { 5, 3, "7", "Category Theory" },
                    { 6, 3, "4", "Complexity Theory" },
                    { 7, 4, "8", "Introduction to Economic Analysis ΙΙ" },
                    { 8, 4, "3", "Microeconomic Theory" },
                    { 9, 5, "7", "Applied Cryptography" },
                    { 10, 5, "3", "Object-oriented programming" },
                    { 11, 6, "8", "Principles of Financial Accounting" },
                    { 12, 6, "5", "Statistics ΙΙ" },
                    { 13, 7, "5", "Introduction to Econometrics" },
                    { 14, 7, "7", "Statistics" },
                    { 15, 8, "8", "Computer Networks" },
                    { 16, 8, "5", "Introduction to operating Systems" },
                    { 17, 9, "1", "Macroeconomic Theory" },
                    { 18, 9, "5", "Economic History" },
                    { 19, 10, "3", "Introduction to Economic Analysis" },
                    { 20, 10, "8", "Mathematics for Economists Ι" }
                });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 443940524, "Informatics", "Thelma", "Mills" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Afm", "Name", "Surname" },
                values: new object[] { 163212525, "Arnold", "Buckridge" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 286652193, "Informatics", "Henri", "Vandervort" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 255179605, "Economics", "Jordyn", "Jacobs" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 430824683, "Informatics", "Destiney", "Murray" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Afm", "Name", "Surname" },
                values: new object[] { 287276767, "Oma", "Spencer" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Afm", "Name", "Surname" },
                values: new object[] { 335540574, "Geoffrey", "Trantow" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 137970219, "Informatics", "Tevin", "Rempel" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 233976405, "Economics", "Javier", "Borer" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 404378109, "Economics", "Kattie", "Botsford" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 194394052, "Economics", "Jannie", "Waelchi" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Afm", "Name", "Surname" },
                values: new object[] { 116321252, "Keven", "Boehm" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 128665219, "Economics", "Glen", "Kassulke" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 335517960, "Informatics", "Keira", "Larson" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 173082468, "Economics", "Fannie", "Gerlach" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Afm", "Name", "Surname" },
                values: new object[] { 348727676, "Patricia", "Rutherford" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Afm", "Name", "Surname" },
                values: new object[] { 373554057, "Jaycee", "Homenick" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 113797021, "Economics", "Tamara", "Waelchi" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 423397640, "Informatics", "Josiane", "Kris" });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Afm", "Department", "Name", "Surname" },
                values: new object[] { 490437810, "Informatics", "Vicente", "Lueilwitz" });
        }
    }
}
