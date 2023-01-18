using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gradeflex.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecretaryDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 61, "OdkabXjzra", "secretary", "Hester_Spinka72" },
                    { 62, "yEmbtdurhb", "secretary", "Deshawn_White63" },
                    { 63, "6gFqwF0tt7", "secretary", "Josiane.Schmidt18" },
                    { 64, "zlXckO7Anq", "secretary", "Assunta61" },
                    { 65, "90MZlkud3Q", "secretary", "Vesta_Runolfsdottir22" }
                });

            migrationBuilder.InsertData(
                table: "Secretaries",
                columns: new[] { "Id", "Department", "Name", "PhoneNumber", "Surname", "UserId" },
                values: new object[,]
                {
                    { 1, "Economics", "Carole", 2106942324, "Pouros", 61 },
                    { 2, "Informatics", "Coty", 2106738705, "Champlin", 62 },
                    { 3, "Economics", "Zoey", 2103820443, "Schimmel", 63 },
                    { 4, "Economics", "Lue", 2100214633, "Nolan", 64 },
                    { 5, "Economics", "Orlando", 2103754641, "Bernier", 65 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Secretaries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Secretaries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Secretaries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Secretaries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Secretaries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);
        }
    }
}
