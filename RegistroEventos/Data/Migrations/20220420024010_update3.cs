using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroEventos.Data.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "estadias",
                columns: table => new
                {
                    id_estadia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reservación_estadia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadias", x => x.id_estadia);
                });

            migrationBuilder.CreateTable(
                name: "tipo_Pagos",
                columns: table => new
                {
                    id_tipo_pago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo_pago = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_Pagos", x => x.id_tipo_pago);
                });

            migrationBuilder.CreateTable(
                name: "comprobantes",
                columns: table => new
                {
                    id_comprobante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comprobante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_tipo_pago = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comprobantes", x => x.id_comprobante);
                    table.ForeignKey(
                        name: "FK_comprobantes_tipo_Pagos_id_tipo_pago",
                        column: x => x.id_tipo_pago,
                        principalTable: "tipo_Pagos",
                        principalColumn: "id_tipo_pago",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "evento_Participantes",
                columns: table => new
                {
                    id_evento_participante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_evento = table.Column<int>(type: "int", nullable: false),
                    id_participante = table.Column<int>(type: "int", nullable: false),
                    id_estadia = table.Column<int>(type: "int", nullable: false),
                    id_comprobante = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evento_Participantes", x => x.id_evento_participante);
                    table.ForeignKey(
                        name: "FK_evento_Participantes_comprobantes_id_comprobante",
                        column: x => x.id_comprobante,
                        principalTable: "comprobantes",
                        principalColumn: "id_comprobante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_evento_Participantes_estadias_id_estadia",
                        column: x => x.id_estadia,
                        principalTable: "estadias",
                        principalColumn: "id_estadia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_evento_Participantes_eventos_id_evento",
                        column: x => x.id_evento,
                        principalTable: "eventos",
                        principalColumn: "id_evento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_evento_Participantes_participantes_id_participante",
                        column: x => x.id_participante,
                        principalTable: "participantes",
                        principalColumn: "id_participante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comprobantes_id_tipo_pago",
                table: "comprobantes",
                column: "id_tipo_pago");

            migrationBuilder.CreateIndex(
                name: "IX_evento_Participantes_id_comprobante",
                table: "evento_Participantes",
                column: "id_comprobante");

            migrationBuilder.CreateIndex(
                name: "IX_evento_Participantes_id_estadia",
                table: "evento_Participantes",
                column: "id_estadia");

            migrationBuilder.CreateIndex(
                name: "IX_evento_Participantes_id_evento",
                table: "evento_Participantes",
                column: "id_evento");

            migrationBuilder.CreateIndex(
                name: "IX_evento_Participantes_id_participante",
                table: "evento_Participantes",
                column: "id_participante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "evento_Participantes");

            migrationBuilder.DropTable(
                name: "comprobantes");

            migrationBuilder.DropTable(
                name: "estadias");

            migrationBuilder.DropTable(
                name: "tipo_Pagos");
        }
    }
}
