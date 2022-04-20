using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroEventos.Data.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tipo_Eventos",
                columns: table => new
                {
                    id_tipo_evento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_tipo_evento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_Eventos", x => x.id_tipo_evento);
                });

            migrationBuilder.CreateTable(
                name: "eventos",
                columns: table => new
                {
                    id_evento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_evento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    lugar_evento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fecha_evento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    id_tipo_evento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventos", x => x.id_evento);
                    table.ForeignKey(
                        name: "FK_eventos_tipo_Eventos_id_tipo_evento",
                        column: x => x.id_tipo_evento,
                        principalTable: "tipo_Eventos",
                        principalColumn: "id_tipo_evento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_eventos_id_tipo_evento",
                table: "eventos",
                column: "id_tipo_evento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eventos");

            migrationBuilder.DropTable(
                name: "tipo_Eventos");
        }
    }
}
