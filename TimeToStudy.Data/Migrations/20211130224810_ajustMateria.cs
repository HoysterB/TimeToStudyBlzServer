using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeToStudy.Data.Migrations
{
    public partial class ajustMateria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_conteudo_tb_materia_MateriaId",
                table: "tb_conteudo");

            migrationBuilder.DropIndex(
                name: "IX_tb_conteudo_MateriaId",
                table: "tb_conteudo");

            migrationBuilder.DropColumn(
                name: "MateriaId",
                table: "tb_conteudo");

            migrationBuilder.AddColumn<int>(
                name: "ConteudoId",
                table: "tb_materia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_materia_ConteudoId",
                table: "tb_materia",
                column: "ConteudoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_materia_tb_conteudo_ConteudoId",
                table: "tb_materia",
                column: "ConteudoId",
                principalTable: "tb_conteudo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_materia_tb_conteudo_ConteudoId",
                table: "tb_materia");

            migrationBuilder.DropIndex(
                name: "IX_tb_materia_ConteudoId",
                table: "tb_materia");

            migrationBuilder.DropColumn(
                name: "ConteudoId",
                table: "tb_materia");

            migrationBuilder.AddColumn<int>(
                name: "MateriaId",
                table: "tb_conteudo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_conteudo_MateriaId",
                table: "tb_conteudo",
                column: "MateriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_conteudo_tb_materia_MateriaId",
                table: "tb_conteudo",
                column: "MateriaId",
                principalTable: "tb_materia",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
