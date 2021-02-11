using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class anioymesenegresos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnioId",
                table: "Egresostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MesId",
                table: "Egresostbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_AnioId",
                table: "Egresostbls",
                column: "AnioId");

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_MesId",
                table: "Egresostbls",
                column: "MesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Egresostbls_Aniostbls_AnioId",
                table: "Egresostbls",
                column: "AnioId",
                principalTable: "Aniostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Egresostbls_Mesestbls_MesId",
                table: "Egresostbls",
                column: "MesId",
                principalTable: "Mesestbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egresostbls_Aniostbls_AnioId",
                table: "Egresostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Egresostbls_Mesestbls_MesId",
                table: "Egresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Egresostbls_AnioId",
                table: "Egresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Egresostbls_MesId",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "AnioId",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "MesId",
                table: "Egresostbls");
        }
    }
}
