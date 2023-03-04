using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektASP.Migrations
{
    /// <inheritdoc />
    public partial class labels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies",
                column: "DirectorId",
                principalTable: "directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "movies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_directors_DirectorId",
                table: "movies",
                column: "DirectorId",
                principalTable: "directors",
                principalColumn: "Id");
        }
    }
}
