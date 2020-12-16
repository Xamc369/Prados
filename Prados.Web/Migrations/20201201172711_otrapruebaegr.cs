using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class otrapruebaegr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContabilidadId",
                table: "Egresostbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_ContabilidadId",
                table: "Egresostbls",
                column: "ContabilidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Egresostbls_Contabilidadtbls_ContabilidadId",
                table: "Egresostbls",
                column: "ContabilidadId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egresostbls_Contabilidadtbls_ContabilidadId",
                table: "Egresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Egresostbls_ContabilidadId",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadId",
                table: "Egresostbls");
        }
    }
}
