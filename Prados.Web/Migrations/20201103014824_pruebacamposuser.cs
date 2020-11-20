using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class pruebacamposuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TipoIdentificaciontbls_TipIdeId",
                table: "Propietariostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TipoPersonastbls_TipPerId",
                table: "Propietariostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TipVivId",
                table: "Propietariostbls");

            migrationBuilder.RenameColumn(
                name: "TipVivId",
                table: "Propietariostbls",
                newName: "TiposViviendatblId");

            migrationBuilder.RenameColumn(
                name: "TipPerId",
                table: "Propietariostbls",
                newName: "TipoPersonatblId");

            migrationBuilder.RenameColumn(
                name: "TipIdeId",
                table: "Propietariostbls",
                newName: "TipoIdentificaciontblId");

            migrationBuilder.RenameIndex(
                name: "IX_Propietariostbls_TipVivId",
                table: "Propietariostbls",
                newName: "IX_Propietariostbls_TiposViviendatblId");

            migrationBuilder.RenameIndex(
                name: "IX_Propietariostbls_TipPerId",
                table: "Propietariostbls",
                newName: "IX_Propietariostbls_TipoPersonatblId");

            migrationBuilder.RenameIndex(
                name: "IX_Propietariostbls_TipIdeId",
                table: "Propietariostbls",
                newName: "IX_Propietariostbls_TipoIdentificaciontblId");

            migrationBuilder.AddColumn<int>(
                name: "TipIdeId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipPerId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipVivId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TipIdeId",
                table: "AspNetUsers",
                column: "TipIdeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TipPerId",
                table: "AspNetUsers",
                column: "TipPerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TipVivId",
                table: "AspNetUsers",
                column: "TipVivId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TipoIdentificaciontbls_TipIdeId",
                table: "AspNetUsers",
                column: "TipIdeId",
                principalTable: "TipoIdentificaciontbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TipoPersonastbls_TipPerId",
                table: "AspNetUsers",
                column: "TipPerId",
                principalTable: "TipoPersonastbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TiposViviendatbls_TipVivId",
                table: "AspNetUsers",
                column: "TipVivId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TipoIdentificaciontbls_TipIdeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TipoPersonastbls_TipPerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TiposViviendatbls_TipVivId",
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
                name: "IX_AspNetUsers_TipIdeId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TipPerId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TipVivId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TipIdeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TipPerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TipVivId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TiposViviendatblId",
                table: "Propietariostbls",
                newName: "TipVivId");

            migrationBuilder.RenameColumn(
                name: "TipoPersonatblId",
                table: "Propietariostbls",
                newName: "TipPerId");

            migrationBuilder.RenameColumn(
                name: "TipoIdentificaciontblId",
                table: "Propietariostbls",
                newName: "TipIdeId");

            migrationBuilder.RenameIndex(
                name: "IX_Propietariostbls_TiposViviendatblId",
                table: "Propietariostbls",
                newName: "IX_Propietariostbls_TipVivId");

            migrationBuilder.RenameIndex(
                name: "IX_Propietariostbls_TipoPersonatblId",
                table: "Propietariostbls",
                newName: "IX_Propietariostbls_TipPerId");

            migrationBuilder.RenameIndex(
                name: "IX_Propietariostbls_TipoIdentificaciontblId",
                table: "Propietariostbls",
                newName: "IX_Propietariostbls_TipIdeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TipoIdentificaciontbls_TipIdeId",
                table: "Propietariostbls",
                column: "TipIdeId",
                principalTable: "TipoIdentificaciontbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TipoPersonastbls_TipPerId",
                table: "Propietariostbls",
                column: "TipPerId",
                principalTable: "TipoPersonastbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TipVivId",
                table: "Propietariostbls",
                column: "TipVivId",
                principalTable: "TiposViviendatbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
