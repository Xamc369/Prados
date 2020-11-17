using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class vehiculosvalidaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Veh_Placa",
                table: "Vehiculostbls",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Veh_Placa",
                table: "Vehiculostbls",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 7);
        }
    }
}
