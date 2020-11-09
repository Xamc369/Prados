using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class Volvi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TipoIdentificaciontbls_Pro_TipoIdentificacionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Pro_TipoIdentificacionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Pro_TipoIdentificacionId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Pro_TipoIdentificacion",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pro_TipoIdentificacion",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Pro_TipoIdentificacionId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Pro_TipoIdentificacionId",
                table: "AspNetUsers",
                column: "Pro_TipoIdentificacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TipoIdentificaciontbls_Pro_TipoIdentificacionId",
                table: "AspNetUsers",
                column: "Pro_TipoIdentificacionId",
                principalTable: "TipoIdentificaciontbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
