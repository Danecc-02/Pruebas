using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroEventos.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tipo_Capitulos",
                columns: table => new
                {
                    id_tipo_capitulo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_tipo_capitulo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_Capitulos", x => x.id_tipo_capitulo);
                });

            migrationBuilder.CreateTable(
                name: "capitulos",
                columns: table => new
                {
                    id_capitulo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_capitulo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    lugar_capitulo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    id_tipo_capitulo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capitulos", x => x.id_capitulo);
                    table.ForeignKey(
                        name: "FK_capitulos_tipo_Capitulos_id_tipo_capitulo",
                        column: x => x.id_tipo_capitulo,
                        principalTable: "tipo_Capitulos",
                        principalColumn: "id_tipo_capitulo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "participantes",
                columns: table => new
                {
                    id_participante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_participante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido_participante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dni_participante = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    id_capitulo = table.Column<int>(type: "int", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_participantes", x => x.id_participante);
                    table.ForeignKey(
                        name: "FK_participantes_capitulos_id_capitulo",
                        column: x => x.id_capitulo,
                        principalTable: "capitulos",
                        principalColumn: "id_capitulo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_capitulos_id_tipo_capitulo",
                table: "capitulos",
                column: "id_tipo_capitulo");

            migrationBuilder.CreateIndex(
                name: "IX_participantes_id_capitulo",
                table: "participantes",
                column: "id_capitulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "participantes");

            migrationBuilder.DropTable(
                name: "capitulos");

            migrationBuilder.DropTable(
                name: "tipo_Capitulos");
        }
    }
}
