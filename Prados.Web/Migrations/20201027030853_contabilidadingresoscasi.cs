using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class contabilidadingresoscasi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Pagostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PagosId",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_ContabilidadtblId",
                table: "Pagostbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_PagosId",
                table: "Contabilidadtbls",
                column: "PagosId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Contabilidadtbls_PagosId",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Pagostbls");

            migrationBuilder.DropColumn(
                name: "PagosId",
                table: "Contabilidadtbls");
        }
    }
}
