using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class prueba5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "Valorestbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Valorestbls_IngresostblId",
                table: "Valorestbls",
                column: "IngresostblId");

            migrationBuilder.AddForeignKey(
                name: "FK_Valorestbls_Ingresostbls_IngresostblId",
                table: "Valorestbls",
                column: "IngresostblId",
                principalTable: "Ingresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Valorestbls_Ingresostbls_IngresostblId",
                table: "Valorestbls");

            migrationBuilder.DropIndex(
                name: "IX_Valorestbls_IngresostblId",
                table: "Valorestbls");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "Valorestbls");
        }
    }
}
