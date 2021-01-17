using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class otrointento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estadostbl_Egresostbls_EgresosId",
                table: "Estadostbl");

            migrationBuilder.DropForeignKey(
                name: "FK_Estadostbl_Pagostbls_IngresosId",
                table: "Estadostbl");

            migrationBuilder.DropIndex(
                name: "IX_Estadostbl_EgresosId",
                table: "Estadostbl");

            migrationBuilder.DropIndex(
                name: "IX_Estadostbl_IngresosId",
                table: "Estadostbl");

            migrationBuilder.DropColumn(
                name: "EgresosId",
                table: "Estadostbl");

            migrationBuilder.DropColumn(
                name: "IngresosId",
                table: "Estadostbl");

            migrationBuilder.AddColumn<int>(
                name: "EstadoFinancieroId",
                table: "Pagostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoFinancieroId",
                table: "Egresostbls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_EstadoFinancieroId",
                table: "Pagostbls",
                column: "EstadoFinancieroId");

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_EstadoFinancieroId",
                table: "Egresostbls",
                column: "EstadoFinancieroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Egresostbls_Estadostbl_EstadoFinancieroId",
                table: "Egresostbls",
                column: "EstadoFinancieroId",
                principalTable: "Estadostbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagostbls_Estadostbl_EstadoFinancieroId",
                table: "Pagostbls",
                column: "EstadoFinancieroId",
                principalTable: "Estadostbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egresostbls_Estadostbl_EstadoFinancieroId",
                table: "Egresostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagostbls_Estadostbl_EstadoFinancieroId",
                table: "Pagostbls");

            migrationBuilder.DropIndex(
                name: "IX_Pagostbls_EstadoFinancieroId",
                table: "Pagostbls");

            migrationBuilder.DropIndex(
                name: "IX_Egresostbls_EstadoFinancieroId",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "EstadoFinancieroId",
                table: "Pagostbls");

            migrationBuilder.DropColumn(
                name: "EstadoFinancieroId",
                table: "Egresostbls");

            migrationBuilder.AddColumn<int>(
                name: "EgresosId",
                table: "Estadostbl",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngresosId",
                table: "Estadostbl",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estadostbl_EgresosId",
                table: "Estadostbl",
                column: "EgresosId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadostbl_IngresosId",
                table: "Estadostbl",
                column: "IngresosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estadostbl_Egresostbls_EgresosId",
                table: "Estadostbl",
                column: "EgresosId",
                principalTable: "Egresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estadostbl_Pagostbls_IngresosId",
                table: "Estadostbl",
                column: "IngresosId",
                principalTable: "Pagostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
