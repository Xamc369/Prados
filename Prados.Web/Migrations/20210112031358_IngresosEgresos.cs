using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class IngresosEgresos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadosFinancierostbls",
                columns: table => new
                {
                    IdIngresos = table.Column<int>(nullable: false),
                    IdEgresos = table.Column<int>(nullable: false),
                    IngresosId = table.Column<int>(nullable: true),
                    EgresosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosFinancierostbls", x => new { x.IdIngresos, x.IdEgresos });
                    table.ForeignKey(
                        name: "FK_EstadosFinancierostbls_Egresostbls_EgresosId",
                        column: x => x.EgresosId,
                        principalTable: "Egresostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EstadosFinancierostbls_Pagostbls_IngresosId",
                        column: x => x.IngresosId,
                        principalTable: "Pagostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstadosFinancierostbls_EgresosId",
                table: "EstadosFinancierostbls",
                column: "EgresosId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosFinancierostbls_IngresosId",
                table: "EstadosFinancierostbls",
                column: "IngresosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadosFinancierostbls");
        }
    }
}
