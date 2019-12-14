using Microsoft.EntityFrameworkCore.Migrations;

namespace FelipeBastosAnotherProject.Migrations
{
    public partial class jogadorfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Placar_Jogador_jogadorId",
                table: "Placar");

            migrationBuilder.RenameColumn(
                name: "jogadorId",
                table: "Placar",
                newName: "jogadorID");

            migrationBuilder.RenameIndex(
                name: "IX_Placar_jogadorId",
                table: "Placar",
                newName: "IX_Placar_jogadorID");

            migrationBuilder.AlterColumn<int>(
                name: "jogadorID",
                table: "Placar",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Placar_Jogador_jogadorID",
                table: "Placar",
                column: "jogadorID",
                principalTable: "Jogador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Placar_Jogador_jogadorID",
                table: "Placar");

            migrationBuilder.RenameColumn(
                name: "jogadorID",
                table: "Placar",
                newName: "jogadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Placar_jogadorID",
                table: "Placar",
                newName: "IX_Placar_jogadorId");

            migrationBuilder.AlterColumn<int>(
                name: "jogadorId",
                table: "Placar",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Placar_Jogador_jogadorId",
                table: "Placar",
                column: "jogadorId",
                principalTable: "Jogador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
