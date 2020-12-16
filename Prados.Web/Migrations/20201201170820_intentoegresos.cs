using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class intentoegresos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contabilidadtbls_Egresostbls_EgrId",
                table: "Contabilidadtbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Egresostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Egresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Egresostbls_ContabilidadtblId",
                table: "Egresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Contabilidadtbls_EgrId",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "EgrId",
                table: "Contabilidadtbls");

            migrationBuilder.AddColumn<string>(
                name: "Con_EgrDescripcion",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Con_EgrFecha",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Con_EgrValor",
                table: "Contabilidadtbls",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Con_EgrDescripcion",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "Con_EgrFecha",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "Con_EgrValor",
                table: "Contabilidadtbls");

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Egresostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EgrId",
                table: "Contabilidadtbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_ContabilidadtblId",
                table: "Egresostbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_EgrId",
                table: "Contabilidadtbls",
                column: "EgrId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contabilidadtbls_Egresostbls_EgrId",
                table: "Contabilidadtbls",
                column: "EgrId",
                principalTable: "Egresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Egresostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Egresostbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
