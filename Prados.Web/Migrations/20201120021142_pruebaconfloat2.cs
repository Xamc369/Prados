using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class pruebaconfloat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Egr_Estado",
                table: "Egresostbls",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Egr_FechadeRegistro",
                table: "Egresostbls",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Egr_Estado",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "Egr_FechadeRegistro",
                table: "Egresostbls");
        }
    }
}
