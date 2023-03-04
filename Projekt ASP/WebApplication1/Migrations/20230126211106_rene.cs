using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektASP.Migrations
{
    /// <inheritdoc />
    public partial class rene : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "movies",
                newName: "ReleaseDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "movies",
                newName: "ReleaseDate");
        }
    }
}
