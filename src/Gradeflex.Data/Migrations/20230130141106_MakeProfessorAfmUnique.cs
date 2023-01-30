using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gradeflex.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeProfessorAfmUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Professors_Afm",
                table: "Professors",
                column: "Afm",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Professors_Afm",
                table: "Professors");
        }
    }
}
