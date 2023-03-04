using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektASP.Migrations
{
    /// <inheritdoc />
    public partial class renadf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data urodzenia",
                table: "directors",
                newName: "Born");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Born",
                table: "directors",
                newName: "Data urodzenia");
        }
    }
}
