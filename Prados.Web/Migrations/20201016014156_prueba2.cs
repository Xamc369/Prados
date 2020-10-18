using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class prueba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_Ingresostbls_IngresostblId",
                table: "Propietariostbls");

            migrationBuilder.DropIndex(
                name: "IX_Propietariostbls_IngresostblId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "Ing_Cuotas",
                table: "Ingresostbls");

            migrationBuilder.AddColumn<int>(
                name: "PagosContId",
                table: "Ingresostbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingresostbls_PagosContId",
                table: "Ingresostbls",
                column: "PagosContId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresostbls_Pagostbls_PagosContId",
                table: "Ingresostbls",
                column: "PagosContId",
                principalTable: "Pagostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingresostbls_Pagostbls_PagosContId",
                table: "Ingresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Ingresostbls_PagosContId",
                table: "Ingresostbls");

            migrationBuilder.DropColumn(
                name: "PagosContId",
                table: "Ingresostbls");

            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "Propietariostbls",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Ing_Cuotas",
                table: "Ingresostbls",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_IngresostblId",
                table: "Propietariostbls",
                column: "IngresostblId");

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_Ingresostbls_IngresostblId",
                table: "Propietariostbls",
                column: "IngresostblId",
                principalTable: "Ingresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
