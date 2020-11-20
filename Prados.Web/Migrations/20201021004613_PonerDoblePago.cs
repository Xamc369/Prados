using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class PonerDoblePago : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "Vehiculostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "Valorestbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PagosContId",
                table: "Ingresostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValId",
                table: "Ingresostbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculostbls_IngresostblId",
                table: "Vehiculostbls",
                column: "IngresostblId");

            migrationBuilder.CreateIndex(
                name: "IX_Valorestbls_IngresostblId",
                table: "Valorestbls",
                column: "IngresostblId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresostbls_PagosContId",
                table: "Ingresostbls",
                column: "PagosContId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresostbls_ValId",
                table: "Ingresostbls",
                column: "ValId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresostbls_Pagostbls_PagosContId",
                table: "Ingresostbls",
                column: "PagosContId",
                principalTable: "Pagostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresostbls_Valorestbls_ValId",
                table: "Ingresostbls",
                column: "ValId",
                principalTable: "Valorestbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Valorestbls_Ingresostbls_IngresostblId",
                table: "Valorestbls",
                column: "IngresostblId",
                principalTable: "Ingresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculostbls_Ingresostbls_IngresostblId",
                table: "Vehiculostbls",
                column: "IngresostblId",
                principalTable: "Ingresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingresostbls_Pagostbls_PagosContId",
                table: "Ingresostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingresostbls_Valorestbls_ValId",
                table: "Ingresostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Valorestbls_Ingresostbls_IngresostblId",
                table: "Valorestbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculostbls_Ingresostbls_IngresostblId",
                table: "Vehiculostbls");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculostbls_IngresostblId",
                table: "Vehiculostbls");

            migrationBuilder.DropIndex(
                name: "IX_Valorestbls_IngresostblId",
                table: "Valorestbls");

            migrationBuilder.DropIndex(
                name: "IX_Ingresostbls_PagosContId",
                table: "Ingresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Ingresostbls_ValId",
                table: "Ingresostbls");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "Vehiculostbls");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "Valorestbls");

            migrationBuilder.DropColumn(
                name: "PagosContId",
                table: "Ingresostbls");

            migrationBuilder.DropColumn(
                name: "ValId",
                table: "Ingresostbls");
        }
    }
}
