using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeToStudy.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_estudante",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    sobrenome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    criado_em = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_estudante", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_revisao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    criado_em = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_revisao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SessoesDeEstudos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    atividadesRealizadas = table.Column<int>(type: "int", nullable: false),
                    atividadesCorretas = table.Column<int>(type: "int", nullable: false),
                    tempoDuracao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstudanteId = table.Column<int>(type: "int", nullable: false),
                    AgendaDeEstudoId = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessoesDeEstudos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessoesDeEstudos_tb_estudante_EstudanteId",
                        column: x => x.EstudanteId,
                        principalTable: "tb_estudante",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_agendaDeEstudo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessaoDeEstudoId = table.Column<int>(type: "int", nullable: false),
                    criado_em = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_agendaDeEstudo", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_agendaDeEstudo_SessoesDeEstudos_SessaoDeEstudoId",
                        column: x => x.SessaoDeEstudoId,
                        principalTable: "SessoesDeEstudos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_materia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstudanteId = table.Column<int>(type: "int", nullable: false),
                    SessaoId = table.Column<int>(type: "int", nullable: false),
                    criado_em = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_materia", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_materia_SessoesDeEstudos_SessaoId",
                        column: x => x.SessaoId,
                        principalTable: "SessoesDeEstudos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_materia_tb_estudante_EstudanteId",
                        column: x => x.EstudanteId,
                        principalTable: "tb_estudante",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_conteudo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    escricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    criado_em = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_conteudo", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_conteudo_tb_materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "tb_materia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SessoesDeEstudos_EstudanteId",
                table: "SessoesDeEstudos",
                column: "EstudanteId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_agendaDeEstudo_SessaoDeEstudoId",
                table: "tb_agendaDeEstudo",
                column: "SessaoDeEstudoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_conteudo_MateriaId",
                table: "tb_conteudo",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_materia_EstudanteId",
                table: "tb_materia",
                column: "EstudanteId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_materia_SessaoId",
                table: "tb_materia",
                column: "SessaoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_agendaDeEstudo");

            migrationBuilder.DropTable(
                name: "tb_conteudo");

            migrationBuilder.DropTable(
                name: "tb_revisao");

            migrationBuilder.DropTable(
                name: "tb_materia");

            migrationBuilder.DropTable(
                name: "SessoesDeEstudos");

            migrationBuilder.DropTable(
                name: "tb_estudante");
        }
    }
}
