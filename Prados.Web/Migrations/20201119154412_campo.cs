using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class campo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Val_Valor2",
                table: "Valorestbls");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Val_Valor2",
                table: "Valorestbls",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
