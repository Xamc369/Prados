using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class contabokmes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Aniostbls_MessId",
                table: "Contabilidadtbls");

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_Mesestbls_MessId",
                table: "Contabilidadtbls",
                column: "MessId",
                principalTable: "Mesestbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Mesestbls_MessId",
                table: "Contabilidadtbls");

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_Aniostbls_MessId",
                table: "Contabilidadtbls",
                column: "MessId",
                principalTable: "Aniostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
