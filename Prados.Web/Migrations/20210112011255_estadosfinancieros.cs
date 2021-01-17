using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class estadosfinancieros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aniostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Aniostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Egresostbls_Contabilidadtbls_ContabilidadId",
                table: "Egresostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Mesestbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Pagostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_PuntosPagotbls_Contabilidadtbls_ContabilidadtblId",
                table: "PuntosPagotbls");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposPagotbl_Contabilidadtbls_ContabilidadtblId",
                table: "TiposPagotbl");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposPagotbl_Ingresostbls_IngresostblId",
                table: "TiposPagotbl");

            migrationBuilder.DropForeignKey(
                name: "FK_Valorestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Valorestbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Valorestbls_Ingresostbls_IngresostblId",
                table: "Valorestbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculostbls_Ingresostbls_IngresostblId",
                table: "Vehiculostbls");

            migrationBuilder.DropTable(
                name: "Contabilidadtbls");

            migrationBuilder.DropTable(
                name: "Ingresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculostbls_IngresostblId",
                table: "Vehiculostbls");

            migrationBuilder.DropIndex(
                name: "IX_Valorestbls_ContabilidadtblId",
                table: "Valorestbls");

            migrationBuilder.DropIndex(
                name: "IX_Valorestbls_IngresostblId",
                table: "Valorestbls");

            migrationBuilder.DropIndex(
                name: "IX_TiposPagotbl_ContabilidadtblId",
                table: "TiposPagotbl");

            migrationBuilder.DropIndex(
                name: "IX_TiposPagotbl_IngresostblId",
                table: "TiposPagotbl");

            migrationBuilder.DropIndex(
                name: "IX_PuntosPagotbls_ContabilidadtblId",
                table: "PuntosPagotbls");

            migrationBuilder.DropIndex(
                name: "IX_Pagostbls_ContabilidadtblId",
                table: "Pagostbls");

            migrationBuilder.DropIndex(
                name: "IX_Mesestbls_ContabilidadtblId",
                table: "Mesestbls");

            migrationBuilder.DropIndex(
                name: "IX_Egresostbls_ContabilidadId",
                table: "Egresostbls");

            migrationBuilder.DropIndex(
                name: "IX_Aniostbls_ContabilidadtblId",
                table: "Aniostbls");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "Vehiculostbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Valorestbls");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "Valorestbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "TiposPagotbl");

            migrationBuilder.DropColumn(
                name: "IngresostblId",
                table: "TiposPagotbl");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "PuntosPagotbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Pagostbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Mesestbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadId",
                table: "Egresostbls");

            migrationBuilder.DropColumn(
                name: "ContabilidadtblId",
                table: "Aniostbls");

            migrationBuilder.CreateTable(
                name: "Estadostbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IngresosId = table.Column<int>(nullable: true),
                    EgresosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadostbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadostbl_Egresostbls_EgresosId",
                        column: x => x.EgresosId,
                        principalTable: "Egresostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estadostbl_Pagostbls_IngresosId",
                        column: x => x.IngresosId,
                        principalTable: "Pagostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estadostbl_EgresosId",
                table: "Estadostbl",
                column: "EgresosId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadostbl_IngresosId",
                table: "Estadostbl",
                column: "IngresosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estadostbl");

            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "Vehiculostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Valorestbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "Valorestbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "TiposPagotbl",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngresostblId",
                table: "TiposPagotbl",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "PuntosPagotbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Pagostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Mesestbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadId",
                table: "Egresostbls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContabilidadtblId",
                table: "Aniostbls",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contabilidadtbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnioId = table.Column<int>(nullable: true),
                    Con_EgrDescripcion = table.Column<string>(nullable: true),
                    Con_EgrFecha = table.Column<string>(nullable: true),
                    Con_EgrValor = table.Column<float>(nullable: false),
                    Con_EstadoEgr = table.Column<string>(nullable: false),
                    Con_EstadoIng = table.Column<string>(nullable: false),
                    MessId = table.Column<int>(nullable: true),
                    PuntId = table.Column<int>(nullable: true),
                    TipId = table.Column<int>(nullable: true),
                    ValoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contabilidadtbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_Aniostbls_AnioId",
                        column: x => x.AnioId,
                        principalTable: "Aniostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_Mesestbls_MessId",
                        column: x => x.MessId,
                        principalTable: "Mesestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_PuntosPagotbls_PuntId",
                        column: x => x.PuntId,
                        principalTable: "PuntosPagotbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_TiposPagotbl_TipId",
                        column: x => x.TipId,
                        principalTable: "TiposPagotbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contabilidadtbls_Valorestbls_ValoId",
                        column: x => x.ValoId,
                        principalTable: "Valorestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingresostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ing_FechadePago = table.Column<DateTime>(nullable: false),
                    Ing_IngId = table.Column<int>(nullable: false),
                    Ing_Sede = table.Column<double>(nullable: false),
                    PagosContId = table.Column<int>(nullable: true),
                    TipId = table.Column<int>(nullable: true),
                    ValId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingresostbls_Pagostbls_PagosContId",
                        column: x => x.PagosContId,
                        principalTable: "Pagostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingresostbls_TiposPagotbl_TipId",
                        column: x => x.TipId,
                        principalTable: "TiposPagotbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingresostbls_Valorestbls_ValId",
                        column: x => x.ValId,
                        principalTable: "Valorestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculostbls_IngresostblId",
                table: "Vehiculostbls",
                column: "IngresostblId");

            migrationBuilder.CreateIndex(
                name: "IX_Valorestbls_ContabilidadtblId",
                table: "Valorestbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Valorestbls_IngresostblId",
                table: "Valorestbls",
                column: "IngresostblId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposPagotbl_ContabilidadtblId",
                table: "TiposPagotbl",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposPagotbl_IngresostblId",
                table: "TiposPagotbl",
                column: "IngresostblId");

            migrationBuilder.CreateIndex(
                name: "IX_PuntosPagotbls_ContabilidadtblId",
                table: "PuntosPagotbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_ContabilidadtblId",
                table: "Pagostbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesestbls_ContabilidadtblId",
                table: "Mesestbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_ContabilidadId",
                table: "Egresostbls",
                column: "ContabilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Aniostbls_ContabilidadtblId",
                table: "Aniostbls",
                column: "ContabilidadtblId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_AnioId",
                table: "Contabilidadtbls",
                column: "AnioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_MessId",
                table: "Contabilidadtbls",
                column: "MessId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_PuntId",
                table: "Contabilidadtbls",
                column: "PuntId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_TipId",
                table: "Contabilidadtbls",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidadtbls_ValoId",
                table: "Contabilidadtbls",
                column: "ValoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresostbls_PagosContId",
                table: "Ingresostbls",
                column: "PagosContId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresostbls_TipId",
                table: "Ingresostbls",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresostbls_ValId",
                table: "Ingresostbls",
                column: "ValId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aniostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Aniostbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Egresostbls_Contabilidadtbls_ContabilidadId",
                table: "Egresostbls",
                column: "ContabilidadId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mesestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Mesestbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagostbls_Contabilidadtbls_ContabilidadtblId",
                table: "Pagostbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PuntosPagotbls_Contabilidadtbls_ContabilidadtblId",
                table: "PuntosPagotbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TiposPagotbl_Contabilidadtbls_ContabilidadtblId",
                table: "TiposPagotbl",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TiposPagotbl_Ingresostbls_IngresostblId",
                table: "TiposPagotbl",
                column: "IngresostblId",
                principalTable: "Ingresostbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Valorestbls_Contabilidadtbls_ContabilidadtblId",
                table: "Valorestbls",
                column: "ContabilidadtblId",
                principalTable: "Contabilidadtbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Valorestbls_Ingresostbls_IngresostblId",
                table: "Valorestbls",
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
    }
}
