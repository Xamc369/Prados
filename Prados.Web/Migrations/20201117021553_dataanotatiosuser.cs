using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class dataanotatiosuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pro_TipoIdentificacion",
                table: "AspNetUsers",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Pro_Lote",
                table: "AspNetUsers",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pro_TipoIdentificacion",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Pro_Lote",
                table: "AspNetUsers",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3);
        }
    }
}
