using Microsoft.EntityFrameworkCore.Migrations;

namespace CuidadoBovino.App.Persistencia.Migrations
{
    public partial class Inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bovinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVeterinario = table.Column<int>(type: "int", nullable: false),
                    IdVisita = table.Column<int>(type: "int", nullable: false),
                    NombreBovino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bovinos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DuenoBovinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuenoBovinos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasMedicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaApertura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVisita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    FrecuCardiaca = table.Column<float>(type: "real", nullable: false),
                    FrecuRespiratoria = table.Column<float>(type: "real", nullable: false),
                    EstadoAnimo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasMedicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecomendaMedicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecomendaGral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendacion2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendacion3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecomendaMedicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veterinarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarjProfesional = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Delefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bovinos");

            migrationBuilder.DropTable(
                name: "DuenoBovinos");

            migrationBuilder.DropTable(
                name: "HistoriasMedicas");

            migrationBuilder.DropTable(
                name: "RecomendaMedicas");

            migrationBuilder.DropTable(
                name: "Veterinarios");
        }
    }
}
