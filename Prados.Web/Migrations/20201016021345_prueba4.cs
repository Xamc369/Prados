using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class prueba4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValId",
                table: "Ingresostbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingresostbls_ValId",
                table: "Ingresostbls",
                column: "ValId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresostbls_Valorestbls_ValId",
                table: "Ingresostbls",
                column: "ValId",
                principalTable: "Valorestbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingresostbls_Valorestbls_ValId",
                table: "Ingresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Ingresostbls_ValId",
                table: "Ingresostbls");

            migrationBuilder.DropColumn(
                name: "ValId",
                table: "Ingresostbls");
        }
    }
}
