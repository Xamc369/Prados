using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class contaboking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Pagostbls_PagosId",
                table: "Contabilidadtbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Pagostbls");

            migrationBuilder.DropIndex(
                name: "IX_Pagostbls_ContabilidadtblId",
                table: "Pagostbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Pagostbls");

            migrationBuilder.DropColumn(
                name: "Con_IngId",
                table: "Contabilidadtbls");

            migrationBuilder.RenameColumn(
                name: "PagosId",
                table: "Contabilidadtbls",
                newName: "ValoId");

            migrationBuilder.RenameIndex(
                name: "IX_Contabilidadtbls_PagosId",
                table: "Contabilidadtbls",
                newName: "IX_Contabilidadtbls_ValoId");

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Valorestbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "PuntosPagotbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnioId",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PuntId",
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
                name: "IX_Contabilidadtbls_AnioId",
                table: "Contabilidadtbls",
                column: "AnioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_PuntId",
                table: "Contabilidadtbls",
                column: "PuntId");

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
                name: "FK_Contabilidadtbls_Aniostbls_AnioId",
                table: "Contabilidadtbls",
                column: "AnioId",
                principalTable: "Aniostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_PuntosPagotbls_PuntId",
                table: "Contabilidadtbls",
                column: "PuntId",
                principalTable: "PuntosPagotbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_Valorestbls_ValoId",
                table: "Contabilidadtbls",
                column: "ValoId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aniostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Aniostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Aniostbls_AnioId",
                table: "Contabilidadtbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_PuntosPagotbls_PuntId",
                table: "Contabilidadtbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Valorestbls_ValoId",
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
                name: "IX_Contabilidadtbls_AnioId",
                table: "Contabilidadtbls");

            migrationBuilder.DropIndex(
                name: "IX_Contabilidadtbls_PuntId",
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
                name: "AnioId",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "PuntId",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Aniostbls");

            migrationBuilder.RenameColumn(
                name: "ValoId",
                table: "Contabilidadtbls",
                newName: "PagosId");

            migrationBuilder.RenameIndex(
                name: "IX_Contabilidadtbls_ValoId",
                table: "Contabilidadtbls",
                newName: "IX_Contabilidadtbls_PagosId");

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Pagostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Con_IngId",
                table: "Contabilidadtbls",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_ContabilidadtblId",
                table: "Pagostbls",
                column: "ContabilidadtblId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_Pagostbls_PagosId",
                table: "Contabilidadtbls",
                column: "PagosId",
                principalTable: "Pagostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Pagostbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
