using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class vehiculosunique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Vehiculostbls_Veh_Codigo",
                table: "Vehiculostbls",
                column: "Veh_Codigo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vehiculostbls_Veh_Codigo",
                table: "Vehiculostbls");
        }
    }
}
