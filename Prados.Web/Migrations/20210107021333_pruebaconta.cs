using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class pruebaconta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Pagostbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_ContabilidadtblId",
                table: "Pagostbls",
                column: "ContabilidadtblId");

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
                name: "FK_Pagostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Pagostbls");

            migrationBuilder.DropIndex(
                name: "IX_Pagostbls_ContabilidadtblId",
                table: "Pagostbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Pagostbls");
        }
    }
}
