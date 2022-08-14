using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ejemplo.Infrastructure.Persistence.Migrations
{
    public partial class ModeloInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Apellidos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Celular = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
