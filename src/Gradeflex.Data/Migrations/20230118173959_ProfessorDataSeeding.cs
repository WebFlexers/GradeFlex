using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gradeflex.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProfessorDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 51, "nDwjY1YOHx", "professor", "Markus_Moen" },
                    { 52, "mMnMe0u_wD", "professor", "Peter.Doyle2" },
                    { 53, "F7En_zLUjo", "professor", "Abbey38" },
                    { 54, "AKTpfsPaH3", "professor", "Kristina_McClure" },
                    { 55, "dmoQ9gE6ol", "professor", "Lillie_Jenkins85" },
                    { 56, "MEHQpB707d", "professor", "King_Langworth84" },
                    { 57, "EAApa_NzLK", "professor", "Tyson_Prosacco62" },
                    { 58, "5XZqrRGmiS", "professor", "Maida.Lesch39" },
                    { 59, "_Oh48FQs0b", "professor", "Jarod.Wilkinson" },
                    { 60, "I72aQw1Wde", "professor", "Brad.OKeefe73" }
                });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "Afm", "Department", "Name", "Surname", "UserId" },
                values: new object[,]
                {
                    { 1, 194394052, "Economics", "Jannie", "Waelchi", 51 },
                    { 2, 116321252, "Informatics", "Keven", "Boehm", 52 },
                    { 3, 128665219, "Economics", "Glen", "Kassulke", 53 },
                    { 4, 335517960, "Informatics", "Keira", "Larson", 54 },
                    { 5, 173082468, "Economics", "Fannie", "Gerlach", 55 },
                    { 6, 348727676, "Economics", "Patricia", "Rutherford", 56 },
                    { 7, 373554057, "Economics", "Jaycee", "Homenick", 57 },
                    { 8, 113797021, "Economics", "Tamara", "Waelchi", 58 },
                    { 9, 423397640, "Informatics", "Josiane", "Kris", 59 },
                    { 10, 490437810, "Informatics", "Vicente", "Lueilwitz", 60 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);
        }
    }
}
