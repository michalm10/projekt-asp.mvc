using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektASP.Migrations
{
    /// <inheritdoc />
    public partial class fkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies",
                column: "DirectorId",
                principalTable: "directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies",
                column: "DirectorId",
                principalTable: "directors",
                principalColumn: "Id");
        }
    }
}
