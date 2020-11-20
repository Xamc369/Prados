using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class Otrosunique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Val_Valor",
                table: "Valorestbls",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tip_Descripcion",
                table: "TiposPagotbl",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pun_Descripcion",
                table: "PuntosPagotbls",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ani_Descripcion",
                table: "Aniostbls",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Valorestbls_Val_Valor",
                table: "Valorestbls",
                column: "Val_Valor",
                unique: true,
                filter: "[Val_Valor] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TiposPagotbl_Tip_Descripcion",
                table: "TiposPagotbl",
                column: "Tip_Descripcion",
                unique: true,
                filter: "[Tip_Descripcion] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PuntosPagotbls_Pun_Descripcion",
                table: "PuntosPagotbls",
                column: "Pun_Descripcion",
                unique: true,
                filter: "[Pun_Descripcion] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Aniostbls_Ani_Descripcion",
                table: "Aniostbls",
                column: "Ani_Descripcion",
                unique: true,
                filter: "[Ani_Descripcion] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Valorestbls_Val_Valor",
                table: "Valorestbls");

            migrationBuilder.DropIndex(
                name: "IX_TiposPagotbl_Tip_Descripcion",
                table: "TiposPagotbl");

            migrationBuilder.DropIndex(
                name: "IX_PuntosPagotbls_Pun_Descripcion",
                table: "PuntosPagotbls");

            migrationBuilder.DropIndex(
                name: "IX_Aniostbls_Ani_Descripcion",
                table: "Aniostbls");

            migrationBuilder.AlterColumn<string>(
                name: "Val_Valor",
                table: "Valorestbls",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tip_Descripcion",
                table: "TiposPagotbl",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pun_Descripcion",
                table: "PuntosPagotbls",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ani_Descripcion",
                table: "Aniostbls",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
