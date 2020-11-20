using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class contabilidadingresosok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aniostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Aniostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Aniostbls_AniId",
                table: "Contabilidadtbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Pagostbls_PagosContId",
                table: "Contabilidadtbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_PuntosPagotbls_PunId",
                table: "Contabilidadtbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Valorestbls_ValId",
                table: "Contabilidadtbls");

            migrationBuilder.DropForeignKey(
                name: "FK_PuntosPagotbls_Contabilidadtbls_ContabilidadtblId",
                table: "PuntosPagotbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Valorestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Valorestbls");

            migrationBuilder.DropIndex(
                name: "IX_Valorestbls_ContabilidadtblId",
                table: "Valorestbls");

            migrationBuilder.DropIndex(
                name: "IX_PuntosPagotbls_ContabilidadtblId",
                table: "PuntosPagotbls");

            migrationBuilder.DropIndex(
                name: "IX_Contabilidadtbls_AniId",
                table: "Contabilidadtbls");

            migrationBuilder.DropIndex(
                name: "IX_Contabilidadtbls_PagosContId",
                table: "Contabilidadtbls");

            migrationBuilder.DropIndex(
                name: "IX_Contabilidadtbls_PunId",
                table: "Contabilidadtbls");

            migrationBuilder.DropIndex(
                name: "IX_Contabilidadtbls_ValId",
                table: "Contabilidadtbls");

            migrationBuilder.DropIndex(
                name: "IX_Aniostbls_ContabilidadtblId",
                table: "Aniostbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Valorestbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "PuntosPagotbls");

            migrationBuilder.DropColumn(
                name: "PAG_TOTAL",
                table: "Pagostbls");

            migrationBuilder.DropColumn(
                name: "AniId",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "PagosContId",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "PunId",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "ValId",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Aniostbls");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Valorestbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "PuntosPagotbls",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PAG_TOTAL",
                table: "Pagostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AniId",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PagosContId",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PunId",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValId",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Aniostbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Valorestbls_ContabilidadtblId",
                table: "Valorestbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_PuntosPagotbls_ContabilidadtblId",
                table: "PuntosPagotbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_AniId",
                table: "Contabilidadtbls",
                column: "AniId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_PagosContId",
                table: "Contabilidadtbls",
                column: "PagosContId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_PunId",
                table: "Contabilidadtbls",
                column: "PunId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_ValId",
                table: "Contabilidadtbls",
                column: "ValId");

            migrationBuilder.CreateIndex(
                name: "IX_Aniostbls_ContabilidadtblId",
                table: "Aniostbls",
                column: "ContabilidadtblId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aniostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Aniostbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_Aniostbls_AniId",
                table: "Contabilidadtbls",
                column: "AniId",
                principalTable: "Aniostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_Pagostbls_PagosContId",
                table: "Contabilidadtbls",
                column: "PagosContId",
                principalTable: "Pagostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_PuntosPagotbls_PunId",
                table: "Contabilidadtbls",
                column: "PunId",
                principalTable: "PuntosPagotbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_Valorestbls_ValId",
                table: "Contabilidadtbls",
                column: "ValId",
                principalTable: "Valorestbls",
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
                name: "FK_Valorestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Valorestbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
