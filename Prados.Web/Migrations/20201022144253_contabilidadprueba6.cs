using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class contabilidadprueba6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Valorestbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "TiposPagotbl",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "PuntosPagotbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Egresostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Aniostbls",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contabilidadtbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EgrId = table.Column<int>(nullable: true),
                    PagosContId = table.Column<int>(nullable: true),
                    ValId = table.Column<int>(nullable: true),
                    TipId = table.Column<int>(nullable: true),
                    PunId = table.Column<int>(nullable: true),
                    AniId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contabilidadtbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_Aniostbls_AniId",
                        column: x => x.AniId,
                        principalTable: "Aniostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_Egresostbls_EgrId",
                        column: x => x.EgrId,
                        principalTable: "Egresostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_Pagostbls_PagosContId",
                        column: x => x.PagosContId,
                        principalTable: "Pagostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_PuntosPagotbls_PunId",
                        column: x => x.PunId,
                        principalTable: "PuntosPagotbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_TiposPagotbl_TipId",
                        column: x => x.TipId,
                        principalTable: "TiposPagotbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_Valorestbls_ValId",
                        column: x => x.ValId,
                        principalTable: "Valorestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Valorestbls_ContabilidadtblId",
                table: "Valorestbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposPagotbl_ContabilidadtblId",
                table: "TiposPagotbl",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_PuntosPagotbls_ContabilidadtblId",
                table: "PuntosPagotbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_ContabilidadtblId",
                table: "Egresostbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Aniostbls_ContabilidadtblId",
                table: "Aniostbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_AniId",
                table: "Contabilidadtbls",
                column: "AniId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_EgrId",
                table: "Contabilidadtbls",
                column: "EgrId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_PagosContId",
                table: "Contabilidadtbls",
                column: "PagosContId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_PunId",
                table: "Contabilidadtbls",
                column: "PunId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_TipId",
                table: "Contabilidadtbls",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_ValId",
                table: "Contabilidadtbls",
                column: "ValId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aniostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Aniostbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Egresostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Egresostbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PuntosPagotbls_Contabilidadtbls_ContabilidadtblId",
                table: "PuntosPagotbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TiposPagotbl_Contabilidadtbls_ContabilidadtblId",
                table: "TiposPagotbl",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Valorestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Valorestbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aniostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Aniostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Egresostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Egresostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_PuntosPagotbls_Contabilidadtbls_ContabilidadtblId",
                table: "PuntosPagotbls");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposPagotbl_Contabilidadtbls_ContabilidadtblId",
                table: "TiposPagotbl");

            migrationBuilder.DropForeignKey(
                name: "FK_Valorestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Valorestbls");

            migrationBuilder.DropTable(
                name: "Contabilidadtbls");

            migrationBuilder.DropIndex(
                name: "IX_Valorestbls_ContabilidadtblId",
                table: "Valorestbls");

            migrationBuilder.DropIndex(
                name: "IX_TiposPagotbl_ContabilidadtblId",
                table: "TiposPagotbl");

            migrationBuilder.DropIndex(
                name: "IX_PuntosPagotbls_ContabilidadtblId",
                table: "PuntosPagotbls");

            migrationBuilder.DropIndex(
                name: "IX_Egresostbls_ContabilidadtblId",
                table: "Egresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Aniostbls_ContabilidadtblId",
                table: "Aniostbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Valorestbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "TiposPagotbl");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "PuntosPagotbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Aniostbls");
        }
    }
}
