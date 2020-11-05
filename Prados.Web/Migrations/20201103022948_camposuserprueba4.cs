using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class camposuserprueba4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TiposViviendatbls_Pro_TipoViviendaId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TipoIdentificaciontbls_TipoIdentificaciontblId",
                table: "Propietariostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TipoPersonastbls_TipoPersonatblId",
                table: "Propietariostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TiposViviendatblId",
                table: "Propietariostbls");

            migrationBuilder.DropIndex(
                name: "IX_Propietariostbls_TipoIdentificaciontblId",
                table: "Propietariostbls");

            migrationBuilder.DropIndex(
                name: "IX_Propietariostbls_TipoPersonatblId",
                table: "Propietariostbls");

            migrationBuilder.DropIndex(
                name: "IX_Propietariostbls_TiposViviendatblId",
                table: "Propietariostbls");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Pro_TipoViviendaId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TipoIdentificaciontblId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "TipoPersonatblId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "TiposViviendatblId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "Pro_TipoViviendaId",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoIdentificaciontblId",
                table: "Propietariostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPersonatblId",
                table: "Propietariostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiposViviendatblId",
                table: "Propietariostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pro_TipoViviendaId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_TipoIdentificaciontblId",
                table: "Propietariostbls",
                column: "TipoIdentificaciontblId");

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_TipoPersonatblId",
                table: "Propietariostbls",
                column: "TipoPersonatblId");

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_TiposViviendatblId",
                table: "Propietariostbls",
                column: "TiposViviendatblId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Pro_TipoViviendaId",
                table: "AspNetUsers",
                column: "Pro_TipoViviendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TiposViviendatbls_Pro_TipoViviendaId",
                table: "AspNetUsers",
                column: "Pro_TipoViviendaId",
                principalTable: "TiposViviendatbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TipoIdentificaciontbls_TipoIdentificaciontblId",
                table: "Propietariostbls",
                column: "TipoIdentificaciontblId",
                principalTable: "TipoIdentificaciontbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TipoPersonastbls_TipoPersonatblId",
                table: "Propietariostbls",
                column: "TipoPersonatblId",
                principalTable: "TipoPersonastbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TiposViviendatblId",
                table: "Propietariostbls",
                column: "TiposViviendatblId",
                principalTable: "TiposViviendatbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
