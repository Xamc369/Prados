using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class otrointento3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egresostbls_Estadostbl_EstadoFinancieroId",
                table: "Egresostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagostbls_Estadostbl_EstadoFinancieroId",
                table: "Pagostbls");

            migrationBuilder.DropTable(
                name: "Estadostbl");

            migrationBuilder.DropIndex(
                name: "IX_Pagostbls_EstadoFinancieroId",
                table: "Pagostbls");

            migrationBuilder.DropIndex(
                name: "IX_Egresostbls_EstadoFinancieroId",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "EstadoFinancieroId",
                table: "Pagostbls");

            migrationBuilder.DropColumn(
                name: "EstadoFinancieroId",
                table: "Egresostbls");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstadoFinancieroId",
                table: "Pagostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoFinancieroId",
                table: "Egresostbls",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Estadostbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadostbl", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_EstadoFinancieroId",
                table: "Pagostbls",
                column: "EstadoFinancieroId");

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_EstadoFinancieroId",
                table: "Egresostbls",
                column: "EstadoFinancieroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Egresostbls_Estadostbl_EstadoFinancieroId",
                table: "Egresostbls",
                column: "EstadoFinancieroId",
                principalTable: "Estadostbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagostbls_Estadostbl_EstadoFinancieroId",
                table: "Pagostbls",
                column: "EstadoFinancieroId",
                principalTable: "Estadostbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
