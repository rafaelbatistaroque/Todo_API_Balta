using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApp.Infra.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: true),
                    Feito = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Usuario = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarefa_Usuario",
                table: "Tarefa",
                column: "Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefa");
        }
    }
}
