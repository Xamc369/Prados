using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class guardadodoble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "TiposPagotbl",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "Ingresostbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TiposPagotbl_IngresostblId",
                table: "TiposPagotbl",
                column: "IngresostblId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresostbls_TipId",
                table: "Ingresostbls",
                column: "TipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresostbls_TiposPagotbl_TipId",
                table: "Ingresostbls",
                column: "TipId",
                principalTable: "TiposPagotbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TiposPagotbl_Ingresostbls_IngresostblId",
                table: "TiposPagotbl",
                column: "IngresostblId",
                principalTable: "Ingresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingresostbls_TiposPagotbl_TipId",
                table: "Ingresostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposPagotbl_Ingresostbls_IngresostblId",
                table: "TiposPagotbl");

            migrationBuilder.DropIndex(
                name: "IX_TiposPagotbl_IngresostblId",
                table: "TiposPagotbl");

            migrationBuilder.DropIndex(
                name: "IX_Ingresostbls_TipId",
                table: "Ingresostbls");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "TiposPagotbl");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "Ingresostbls");
        }
    }
}
