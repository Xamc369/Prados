using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class Contabilidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "Vehiculostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "Propietariostbls",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Egresostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egresostbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingresostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ing_Cuotas = table.Column<double>(nullable: false),
                    Ing_Tag = table.Column<double>(nullable: false),
                    Ing_Sede = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresostbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Saldostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldostbls", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculostbls_IngresostblId",
                table: "Vehiculostbls",
                column: "IngresostblId");

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_IngresostblId",
                table: "Propietariostbls",
                column: "IngresostblId");

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_Ingresostbls_IngresostblId",
                table: "Propietariostbls",
                column: "IngresostblId",
                principalTable: "Ingresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculostbls_Ingresostbls_IngresostblId",
                table: "Vehiculostbls",
                column: "IngresostblId",
                principalTable: "Ingresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_Ingresostbls_IngresostblId",
                table: "Propietariostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculostbls_Ingresostbls_IngresostblId",
                table: "Vehiculostbls");

            migrationBuilder.DropTable(
                name: "Egresostbls");

            migrationBuilder.DropTable(
                name: "Ingresostbls");

            migrationBuilder.DropTable(
                name: "Saldostbls");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculostbls_IngresostblId",
                table: "Vehiculostbls");

            migrationBuilder.DropIndex(
                name: "IX_Propietariostbls_IngresostblId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "Vehiculostbls");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "Propietariostbls");
        }
    }
}
