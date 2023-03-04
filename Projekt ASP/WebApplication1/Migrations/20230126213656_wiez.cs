using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektASP.Migrations
{
    /// <inheritdoc />
    public partial class wiez : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_movies_DirectorId",
                table: "movies",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies",
                column: "DirectorId",
                principalTable: "directors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies");

            migrationBuilder.DropIndex(
                name: "IX_movies_DirectorId",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "movies");
        }
    }
}
