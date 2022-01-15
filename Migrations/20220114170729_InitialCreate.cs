using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace abw2_ef.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    CarreraID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.CarreraID);
                });

            migrationBuilder.CreateTable(
                name: "Convocatoria",
                columns: table => new
                {
                    ConvocatoriaID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Mes = table.Column<int>(type: "integer", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convocatoria", x => x.ConvocatoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    AlumnoID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Dip = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Apellidos = table.Column<string>(type: "text", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CarreraID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.AlumnoID);
                    table.ForeignKey(
                        name: "FK_Alumnos_Carreras_CarreraID",
                        column: x => x.CarreraID,
                        principalTable: "Carreras",
                        principalColumn: "CarreraID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    AsignaturaID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Creditos = table.Column<int>(type: "integer", nullable: false),
                    CarreraID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.AsignaturaID);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Carreras_CarreraID",
                        column: x => x.CarreraID,
                        principalTable: "Carreras",
                        principalColumn: "CarreraID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    MatriculaID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AlumnoID = table.Column<int>(type: "integer", nullable: false),
                    AsignaturaID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.MatriculaID);
                    table.ForeignKey(
                        name: "FK_Matriculas_Alumnos_AlumnoID",
                        column: x => x.AlumnoID,
                        principalTable: "Alumnos",
                        principalColumn: "AlumnoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Asignaturas_AsignaturaID",
                        column: x => x.AsignaturaID,
                        principalTable: "Asignaturas",
                        principalColumn: "AsignaturaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    CalificacionID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConvocatiriaID = table.Column<int>(type: "integer", nullable: false),
                    MatriculaID = table.Column<int>(type: "integer", nullable: false),
                    NotaNumerica = table.Column<int>(type: "integer", nullable: true),
                    NotaCategorica = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.CalificacionID);
                    table.ForeignKey(
                        name: "FK_Calificaciones_Convocatoria_ConvocatiriaID",
                        column: x => x.ConvocatiriaID,
                        principalTable: "Convocatoria",
                        principalColumn: "ConvocatoriaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calificaciones_Matriculas_MatriculaID",
                        column: x => x.MatriculaID,
                        principalTable: "Matriculas",
                        principalColumn: "MatriculaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_CarreraID",
                table: "Alumnos",
                column: "CarreraID");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_CarreraID",
                table: "Asignaturas",
                column: "CarreraID");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_ConvocatiriaID",
                table: "Calificaciones",
                column: "ConvocatiriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_MatriculaID",
                table: "Calificaciones",
                column: "MatriculaID");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_AlumnoID",
                table: "Matriculas",
                column: "AlumnoID");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_AsignaturaID",
                table: "Matriculas",
                column: "AsignaturaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "Convocatoria");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Carreras");
        }
    }
}
