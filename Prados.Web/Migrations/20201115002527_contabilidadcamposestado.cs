using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class contabilidadcamposestado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Con_EstadoEgr",
                table: "Contabilidadtbls",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Con_EstadoIng",
                table: "Contabilidadtbls",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Con_EstadoEgr",
                table: "Contabilidadtbls");

            migrationBuilder.DropColumn(
                name: "Con_EstadoIng",
                table: "Contabilidadtbls");
        }
    }
}
