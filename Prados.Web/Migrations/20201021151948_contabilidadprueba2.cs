using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class contabilidadprueba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Egr_Descripcion",
                table: "Egresostbls",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Egr_FechadePago",
                table: "Egresostbls",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Egr_Valor",
                table: "Egresostbls",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Egr_Descripcion",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "Egr_FechadePago",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "Egr_Valor",
                table: "Egresostbls");
        }
    }
}
