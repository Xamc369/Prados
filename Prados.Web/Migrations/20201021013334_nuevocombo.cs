using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class nuevocombo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Val_TipoPago",
                table: "Valorestbls");

            migrationBuilder.AddColumn<int>(
                name: "TiposId",
                table: "Pagostbls",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TiposPagotbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tip_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPagotbl", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_TiposId",
                table: "Pagostbls",
                column: "TiposId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagostbls_TiposPagotbl_TiposId",
                table: "Pagostbls",
                column: "TiposId",
                principalTable: "TiposPagotbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagostbls_TiposPagotbl_TiposId",
                table: "Pagostbls");

            migrationBuilder.DropTable(
                name: "TiposPagotbl");

            migrationBuilder.DropIndex(
                name: "IX_Pagostbls_TiposId",
                table: "Pagostbls");

            migrationBuilder.DropColumn(
                name: "TiposId",
                table: "Pagostbls");

            migrationBuilder.AddColumn<string>(
                name: "Val_TipoPago",
                table: "Valorestbls",
                nullable: true);
        }
    }
}
