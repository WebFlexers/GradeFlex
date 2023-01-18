using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gradeflex.Data.Migrations
{
    /// <inheritdoc />
    public partial class StudentDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Courses_CourseId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Students_StudentId",
                table: "Grade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grade",
                table: "Grade");

            migrationBuilder.RenameTable(
                name: "Grade",
                newName: "Grades");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_StudentId",
                table: "Grades",
                newName: "IX_Grades_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_CourseId",
                table: "Grades",
                newName: "IX_Grades_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "qhE1stPv7e", "student", "Esta27" },
                    { 2, "UzuQW7cnng", "student", "Berneice.Anderson3" },
                    { 3, "qWoyQVd2wC", "student", "Clint79" },
                    { 4, "lf9PUBSlx7", "student", "Darion37" },
                    { 5, "RYDgJrk_NQ", "student", "Holly.Schmeler" },
                    { 6, "oqXLHhvwuV", "student", "Cristobal_Schaefer87" },
                    { 7, "6EKTusVJyC", "student", "Leif_Tremblay42" },
                    { 8, "ElgWEvxUSL", "student", "Lavinia48" },
                    { 9, "Gk_tWSFcvZ", "student", "Savanah.Bayer" },
                    { 10, "0diQDeLHJO", "student", "Hugh.Kerluke29" },
                    { 11, "Ii3gZvjQew", "student", "Kacey.Wolff" },
                    { 12, "k6ttm6r3ZD", "student", "Alene42" },
                    { 13, "yHrberJefI", "student", "Lawrence97" },
                    { 14, "DWfz0LIMjm", "student", "Bobby.Daugherty" },
                    { 15, "jmdsmszM2p", "student", "Weston33" },
                    { 16, "YTEmjTmXzx", "student", "Kayley.Wuckert91" },
                    { 17, "UxqrEpLlMw", "student", "Jamar.Bosco33" },
                    { 18, "WjDySwDMD2", "student", "Presley.Wiza" },
                    { 19, "Oi778g_zpG", "student", "Lavonne.Lang97" },
                    { 20, "wSGDhvK93x", "student", "Delphine_Wilderman" },
                    { 21, "xRvZU_rhIF", "student", "Nigel33" },
                    { 22, "Ez5rNAPSBf", "student", "Pansy_Heller" },
                    { 23, "dmOLTZMqGA", "student", "Gracie_Will47" },
                    { 24, "cTlUCMuiff", "student", "Florine69" },
                    { 25, "KVazEVyiyQ", "student", "Weldon.Dare16" },
                    { 26, "6pD05_821P", "student", "Nathanial42" },
                    { 27, "AeLnRVVT70", "student", "Alfonso.Jacobson" },
                    { 28, "gmDIeJgnav", "student", "Greyson13" },
                    { 29, "e20PkD0l0W", "student", "Georgette_Bergnaum" },
                    { 30, "xElwubD7D0", "student", "Rylan_Berge" },
                    { 31, "hn1Z4wy9P0", "student", "Kathryne_Brown71" },
                    { 32, "eod2FAzj69", "student", "Olaf32" },
                    { 33, "sVVdLqEEZG", "student", "Darrick_Dibbert" },
                    { 34, "x__HXc9KRA", "student", "Jade48" },
                    { 35, "cFXlzs0wjN", "student", "Mustafa_Towne" },
                    { 36, "tyuBr_Yqds", "student", "Alexis_Price92" },
                    { 37, "z1cj8wP6he", "student", "Judson49" },
                    { 38, "peoEfEpKSZ", "student", "Jamar58" },
                    { 39, "2V25sp8QA0", "student", "Neva_Watsica64" },
                    { 40, "PTZbRwyhRY", "student", "Burnice12" },
                    { 41, "4rOEHm52Vz", "student", "Darren_Schmidt90" },
                    { 42, "1be4GQCrkP", "student", "Anahi10" },
                    { 43, "dhGWiMTdao", "student", "Hazle_Quigley" },
                    { 44, "KZ2m0hjmMI", "student", "Art62" },
                    { 45, "Us5XKVIUo0", "student", "Tiara49" },
                    { 46, "nTbhNawGsF", "student", "Amara46" },
                    { 47, "je5YTPKzK7", "student", "Carmela.McDermott89" },
                    { 48, "XeXR_XWL0P", "student", "Joseph.Huel68" },
                    { 49, "4anfKB6HuE", "student", "Fleta.Kutch" },
                    { 50, "TVMpGLNOPi", "student", "Reinhold44" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "Name", "RegistrationNumber", "Surname", "UserId" },
                values: new object[,]
                {
                    { 1, "Economics", "Crystel", 1900, "Keeling", 1 },
                    { 2, "Informatics", "Darien", 1900, "Roberts", 2 },
                    { 3, "Informatics", "Antonietta", 1901, "Windler", 3 },
                    { 4, "Economics", "Esperanza", 1901, "Bechtelar", 4 },
                    { 5, "Informatics", "Anastasia", 1902, "Bechtelar", 5 },
                    { 6, "Economics", "Armand", 1902, "Connelly", 6 },
                    { 7, "Economics", "Lorenzo", 1903, "Hegmann", 7 },
                    { 8, "Economics", "Ali", 1904, "Bergstrom", 8 },
                    { 9, "Informatics", "Connie", 1903, "Wilkinson", 9 },
                    { 10, "Economics", "Leola", 1905, "Nienow", 10 },
                    { 11, "Economics", "Monique", 1906, "Schultz", 11 },
                    { 12, "Informatics", "Maeve", 1904, "Hauck", 12 },
                    { 13, "Informatics", "Philip", 1905, "Sporer", 13 },
                    { 14, "Economics", "Roderick", 1907, "Jaskolski", 14 },
                    { 15, "Economics", "Oral", 1908, "Runolfsson", 15 },
                    { 16, "Economics", "Rashawn", 1909, "Johns", 16 },
                    { 17, "Informatics", "Jayme", 1906, "Johnston", 17 },
                    { 18, "Informatics", "Jacquelyn", 1907, "Adams", 18 },
                    { 19, "Informatics", "Sherwood", 1908, "Daugherty", 19 },
                    { 20, "Informatics", "Sanford", 1909, "Balistreri", 20 },
                    { 21, "Economics", "Lucy", 1910, "Kohler", 21 },
                    { 22, "Informatics", "Nils", 1910, "Mitchell", 22 },
                    { 23, "Informatics", "Rylan", 1911, "Jacobi", 23 },
                    { 24, "Economics", "Marco", 1911, "Graham", 24 },
                    { 25, "Informatics", "Alivia", 1912, "Schmeler", 25 },
                    { 26, "Economics", "Adell", 1912, "Gibson", 26 },
                    { 27, "Informatics", "Gordon", 1913, "Hudson", 27 },
                    { 28, "Economics", "Brendon", 1913, "Cassin", 28 },
                    { 29, "Informatics", "Jon", 1914, "Goldner", 29 },
                    { 30, "Economics", "Travis", 1914, "Russel", 30 },
                    { 31, "Informatics", "Orlo", 1915, "Ward", 31 },
                    { 32, "Economics", "Rahsaan", 1915, "Dietrich", 32 },
                    { 33, "Economics", "Keaton", 1916, "Auer", 33 },
                    { 34, "Informatics", "Mina", 1916, "Will", 34 },
                    { 35, "Informatics", "Mitchell", 1917, "Schulist", 35 },
                    { 36, "Informatics", "Arielle", 1918, "Johnson", 36 },
                    { 37, "Informatics", "Jeffery", 1919, "Terry", 37 },
                    { 38, "Economics", "Anita", 1917, "Kozey", 38 },
                    { 39, "Economics", "Delphine", 1918, "Langosh", 39 },
                    { 40, "Informatics", "Bernadette", 1920, "Franecki", 40 },
                    { 41, "Informatics", "Hilbert", 1921, "Walsh", 41 },
                    { 42, "Economics", "Keara", 1919, "Toy", 42 },
                    { 43, "Informatics", "Jarrett", 1922, "Feeney", 43 },
                    { 44, "Economics", "Zakary", 1920, "Klein", 44 },
                    { 45, "Informatics", "Bridie", 1923, "Padberg", 45 },
                    { 46, "Informatics", "Judah", 1924, "Jast", 46 },
                    { 47, "Informatics", "Arnoldo", 1925, "Kerluke", 47 },
                    { 48, "Economics", "Laverne", 1921, "King", 48 },
                    { 49, "Economics", "Dawn", 1922, "Ratke", 49 },
                    { 50, "Informatics", "Chelsie", 1926, "Macejkovic", 50 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Courses_CourseId",
                table: "Grades",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Courses_CourseId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "Grade");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_StudentId",
                table: "Grade",
                newName: "IX_Grade_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_CourseId",
                table: "Grade",
                newName: "IX_Grade_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grade",
                table: "Grade",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Courses_CourseId",
                table: "Grade",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Students_StudentId",
                table: "Grade",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
