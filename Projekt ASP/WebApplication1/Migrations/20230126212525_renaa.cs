using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektASP.Migrations
{
    /// <inheritdoc />
    public partial class renaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Born",
                table: "directors",
                newName: "Data urodzenia");

            migrationBuilder.AddColumn<string>(
                name: "Nazwisko",
                table: "directors",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nazwisko",
                table: "directors");

            migrationBuilder.RenameColumn(
                name: "Data urodzenia",
                table: "directors",
                newName: "Born");
        }
    }
}
