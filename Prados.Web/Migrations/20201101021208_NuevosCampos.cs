using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class NuevosCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TiposViviendatblId",
                table: "Propietariostbls");

            migrationBuilder.RenameColumn(
                name: "Tip_Descripcion",
                table: "TiposViviendatbls",
                newName: "TipV_Descripcion");

            migrationBuilder.RenameColumn(
                name: "TiposViviendatblId",
                table: "Propietariostbls",
                newName: "TipVivId");

            migrationBuilder.RenameIndex(
                name: "IX_Propietariostbls_TiposViviendatblId",
                table: "Propietariostbls",
                newName: "IX_Propietariostbls_TipVivId");

            migrationBuilder.AddColumn<int>(
                name: "TipIdeId",
                table: "Propietariostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipPerId",
                table: "Propietariostbls",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipoIdentificaciontbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipI_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIdentificaciontbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersonastbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipP_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersonastbls", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_TipIdeId",
                table: "Propietariostbls",
                column: "TipIdeId");

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_TipPerId",
                table: "Propietariostbls",
                column: "TipPerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TipoIdentificaciontbls_TipIdeId",
                table: "Propietariostbls",
                column: "TipIdeId",
                principalTable: "TipoIdentificaciontbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TipoPersonastbls_TipPerId",
                table: "Propietariostbls",
                column: "TipPerId",
                principalTable: "TipoPersonastbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TipVivId",
                table: "Propietariostbls",
                column: "TipVivId",
                principalTable: "TiposViviendatbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TipoIdentificaciontbls_TipIdeId",
                table: "Propietariostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TipoPersonastbls_TipPerId",
                table: "Propietariostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TipVivId",
                table: "Propietariostbls");

            migrationBuilder.DropTable(
                name: "TipoIdentificaciontbls");

            migrationBuilder.DropTable(
                name: "TipoPersonastbls");

            migrationBuilder.DropIndex(
                name: "IX_Propietariostbls_TipIdeId",
                table: "Propietariostbls");

            migrationBuilder.DropIndex(
                name: "IX_Propietariostbls_TipPerId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "TipIdeId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "TipPerId",
                table: "Propietariostbls");

            migrationBuilder.RenameColumn(
                name: "TipV_Descripcion",
                table: "TiposViviendatbls",
                newName: "Tip_Descripcion");

            migrationBuilder.RenameColumn(
                name: "TipVivId",
                table: "Propietariostbls",
                newName: "TiposViviendatblId");

            migrationBuilder.RenameIndex(
                name: "IX_Propietariostbls_TipVivId",
                table: "Propietariostbls",
                newName: "IX_Propietariostbls_TiposViviendatblId");

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TiposViviendatblId",
                table: "Propietariostbls",
                column: "TiposViviendatblId",
                principalTable: "TiposViviendatbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
