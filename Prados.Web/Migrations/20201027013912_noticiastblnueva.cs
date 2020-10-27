using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class noticiastblnueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Not_FechaCreacion",
                table: "Noticiastbls");

            migrationBuilder.AddColumn<string>(
                name: "Not_Autor",
                table: "Noticiastbls",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Not_Titulo",
                table: "Noticiastbls",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Not_Autor",
                table: "Noticiastbls");

            migrationBuilder.DropColumn(
                name: "Not_Titulo",
                table: "Noticiastbls");

            migrationBuilder.AddColumn<DateTime>(
                name: "Not_FechaCreacion",
                table: "Noticiastbls",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
