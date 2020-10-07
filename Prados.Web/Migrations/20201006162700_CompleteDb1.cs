using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prados.Web.Migrations
{
    public partial class CompleteDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TiposViviendatblId",
                table: "Propietariostbls",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Propietariostbls",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Aniostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ani_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aniostbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managerstbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managerstbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarcasAutostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mar_Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcasAutostbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesestbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mes_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesestbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Negociostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Neg_Nombre = table.Column<string>(nullable: true),
                    Neg_Descripcion = table.Column<string>(nullable: true),
                    Neg_Telefono = table.Column<string>(nullable: true),
                    Neg_Direccion = table.Column<string>(nullable: true),
                    Neg_Email = table.Column<string>(nullable: true),
                    Neg_FechaCreacion = table.Column<DateTime>(nullable: false),
                    Neg_Estado = table.Column<string>(nullable: false),
                    PropietariosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negociostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Negociostbls_Propietariostbls_PropietariosId",
                        column: x => x.PropietariosId,
                        principalTable: "Propietariostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PuntosPagotbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pun_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntosPagotbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposViviendatbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tip_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposViviendatbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Valorestbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Val_Valor = table.Column<string>(nullable: true),
                    Val_FechaCreacion = table.Column<DateTime>(nullable: false),
                    Val_Estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valorestbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Veh_Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Veh_Placa = table.Column<string>(maxLength: 4, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Veh_Estado = table.Column<string>(nullable: true),
                    Veh_Born = table.Column<DateTime>(nullable: false),
                    Veh_Detalles = table.Column<string>(nullable: true),
                    PropietarioId = table.Column<int>(nullable: true),
                    MarcasAutostblId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculostbls_MarcasAutostbls_MarcasAutostblId",
                        column: x => x.MarcasAutostblId,
                        principalTable: "MarcasAutostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculostbls_Propietariostbls_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietariostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pro_Nombre = table.Column<string>(nullable: true),
                    Pro_Precio = table.Column<string>(nullable: true),
                    Pro_FechaCreacion = table.Column<DateTime>(nullable: false),
                    Pro_Estado = table.Column<string>(nullable: false),
                    NegocioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productostbls_Negociostbls_NegocioId",
                        column: x => x.NegocioId,
                        principalTable: "Negociostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Userstbl",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Pro_Lote = table.Column<string>(maxLength: 4, nullable: false),
                    Pro_TipoViviendaId = table.Column<int>(nullable: true),
                    Pro_Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Pro_Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Pro_Observaciones = table.Column<string>(nullable: true),
                    Pro_Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Pro_TipoIdentificacion = table.Column<string>(nullable: false),
                    Pro_Identificacion = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userstbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Userstbl_TiposViviendatbls_Pro_TipoViviendaId",
                        column: x => x.Pro_TipoViviendaId,
                        principalTable: "TiposViviendatbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PAG_FECHAPAGADO = table.Column<DateTime>(nullable: false),
                    PAG_FECHACREACION = table.Column<DateTime>(nullable: false),
                    PAG_ESTADO = table.Column<string>(nullable: false),
                    PropietarioId = table.Column<int>(nullable: true),
                    AnioId = table.Column<int>(nullable: true),
                    MesId = table.Column<int>(nullable: true),
                    ValId = table.Column<int>(nullable: true),
                    PuntodePagoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagostbls_Aniostbls_AnioId",
                        column: x => x.AnioId,
                        principalTable: "Aniostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagostbls_Mesestbls_MesId",
                        column: x => x.MesId,
                        principalTable: "Mesestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagostbls_Propietariostbls_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietariostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagostbls_PuntosPagotbls_PuntodePagoId",
                        column: x => x.PuntodePagoId,
                        principalTable: "PuntosPagotbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagostbls_Valorestbls_ValId",
                        column: x => x.ValId,
                        principalTable: "Valorestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_TiposViviendatblId",
                table: "Propietariostbls",
                column: "TiposViviendatblId");

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_UserId",
                table: "Propietariostbls",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Negociostbls_PropietariosId",
                table: "Negociostbls",
                column: "PropietariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_AnioId",
                table: "Pagostbls",
                column: "AnioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_MesId",
                table: "Pagostbls",
                column: "MesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_PropietarioId",
                table: "Pagostbls",
                column: "PropietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_PuntodePagoId",
                table: "Pagostbls",
                column: "PuntodePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_ValId",
                table: "Pagostbls",
                column: "ValId");

            migrationBuilder.CreateIndex(
                name: "IX_Productostbls_NegocioId",
                table: "Productostbls",
                column: "NegocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Userstbl_Pro_TipoViviendaId",
                table: "Userstbl",
                column: "Pro_TipoViviendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculostbls_MarcasAutostblId",
                table: "Vehiculostbls",
                column: "MarcasAutostblId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculostbls_PropietarioId",
                table: "Vehiculostbls",
                column: "PropietarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TiposViviendatblId",
                table: "Propietariostbls",
                column: "TiposViviendatblId",
                principalTable: "TiposViviendatbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietariostbls_Userstbl_UserId",
                table: "Propietariostbls",
                column: "UserId",
                principalTable: "Userstbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_TiposViviendatbls_TiposViviendatblId",
                table: "Propietariostbls");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietariostbls_Userstbl_UserId",
                table: "Propietariostbls");

            migrationBuilder.DropTable(
                name: "Managerstbls");

            migrationBuilder.DropTable(
                name: "Pagostbls");

            migrationBuilder.DropTable(
                name: "Productostbls");

            migrationBuilder.DropTable(
                name: "Userstbl");

            migrationBuilder.DropTable(
                name: "Vehiculostbls");

            migrationBuilder.DropTable(
                name: "Aniostbls");

            migrationBuilder.DropTable(
                name: "Mesestbls");

            migrationBuilder.DropTable(
                name: "PuntosPagotbls");

            migrationBuilder.DropTable(
                name: "Valorestbls");

            migrationBuilder.DropTable(
                name: "Negociostbls");

            migrationBuilder.DropTable(
                name: "TiposViviendatbls");

            migrationBuilder.DropTable(
                name: "MarcasAutostbls");

            migrationBuilder.DropIndex(
                name: "IX_Propietariostbls_TiposViviendatblId",
                table: "Propietariostbls");

            migrationBuilder.DropIndex(
                name: "IX_Propietariostbls_UserId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "TiposViviendatblId",
                table: "Propietariostbls");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Propietariostbls");
        }
    }
}
