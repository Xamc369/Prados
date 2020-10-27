using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class contabokingMES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Mesestbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MessId",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mesestbls_ContabilidadtblId",
                table: "Mesestbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_MessId",
                table: "Contabilidadtbls",
                column: "MessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_Aniostbls_MessId",
                table: "Contabilidadtbls",
                column: "MessId",
                principalTable: "Aniostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mesestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Mesestbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Aniostbls_MessId",
                table: "Contabilidadtbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Mesestbls");

            migrationBuilder.DropIndex(
                name: "IX_Mesestbls_ContabilidadtblId",
                table: "Mesestbls");

            migrationBuilder.DropIndex(
                name: "IX_Contabilidadtbls_MessId",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Mesestbls");

            migrationBuilder.DropColumn(
                name: "MessId",
                table: "Contabilidadtbls");
        }
    }
}
