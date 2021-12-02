using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeToStudy.Data.Migrations
{
    public partial class ajustS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_materia_SessoesDeEstudos_SessaoId",
                table: "tb_materia");

            migrationBuilder.DropIndex(
                name: "IX_tb_materia_SessaoId",
                table: "tb_materia");

            migrationBuilder.DropColumn(
                name: "SessaoId",
                table: "tb_materia");

            migrationBuilder.DropColumn(
                name: "MateriaId",
                table: "SessoesDeEstudos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SessaoId",
                table: "tb_materia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MateriaId",
                table: "SessoesDeEstudos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_materia_SessaoId",
                table: "tb_materia",
                column: "SessaoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_materia_SessoesDeEstudos_SessaoId",
                table: "tb_materia",
                column: "SessaoId",
                principalTable: "SessoesDeEstudos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
