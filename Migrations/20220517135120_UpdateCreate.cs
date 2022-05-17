using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class UpdateCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aspirantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    ApruebaEvaluacion = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aspirantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "grados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Cupo = table.Column<int>(nullable: false),
                    EstudiantesAsignados = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "matriculas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matriculas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sedes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JornadaId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sedes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SedeId = table.Column<int>(nullable: false),
                    GradoId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Cupo = table.Column<int>(nullable: false),
                    EstudAsignados = table.Column<int>(nullable: false),
                    CupoDisponible = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cursos_grados_GradoId",
                        column: x => x.GradoId,
                        principalTable: "grados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_sedes_SedeId",
                        column: x => x.SedeId,
                        principalTable: "sedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursoId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    AsigCursoActiva = table.Column<bool>(nullable: false),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estudiantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estudiantes_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservaCupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    EstudianteId = table.Column<int>(nullable: false),
                    AspiranteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservaCupos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservaCupos_aspirantes_AspiranteId",
                        column: x => x.AspiranteId,
                        principalTable: "aspirantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservaCupos_estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cursos_GradoId",
                table: "cursos",
                column: "GradoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_SedeId",
                table: "cursos",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_estudiantes_CursoId",
                table: "estudiantes",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_reservaCupos_AspiranteId",
                table: "reservaCupos",
                column: "AspiranteId");

            migrationBuilder.CreateIndex(
                name: "IX_reservaCupos_EstudianteId",
                table: "reservaCupos",
                column: "EstudianteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "matriculas");

            migrationBuilder.DropTable(
                name: "reservaCupos");

            migrationBuilder.DropTable(
                name: "aspirantes");

            migrationBuilder.DropTable(
                name: "estudiantes");

            migrationBuilder.DropTable(
                name: "cursos");

            migrationBuilder.DropTable(
                name: "grados");

            migrationBuilder.DropTable(
                name: "sedes");
        }
    }
}
