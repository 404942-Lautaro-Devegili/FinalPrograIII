using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProg.Migrations
{
    /// <inheritdoc />
    public partial class primerMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuraciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuraciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposSucursal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposSucursal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTipo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdProvincia = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sucursales_Provincias_IdProvincia",
                        column: x => x.IdProvincia,
                        principalTable: "Provincias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sucursales_TiposSucursal_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "TiposSucursal",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Configuraciones",
                columns: new[] { "Id", "Nombre", "Valor" },
                values: new object[,]
                {
                    { new Guid("0218f171-ae2b-44ab-9440-92b1bf05ab8f"), "padding-top", "50px" },
                    { new Guid("a0182e62-420e-4941-be49-9b359716c59a"), "padding-left", "100px" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("39720254-ca8e-4aaf-a70c-b445850e8c23"), "Córdoba" },
                    { new Guid("ad82b082-eb91-4fbb-8218-6fcfac0f91ef"), "Buenos Aires" },
                    { new Guid("b9d686f4-4cd2-4382-bdd6-a39803fc31b3"), "Salta" }
                });

            migrationBuilder.InsertData(
                table: "TiposSucursal",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("19154042-35ab-4533-8b3b-7d02f69721e4"), "Grande" },
                    { new Guid("f861c32f-8264-483c-b63a-40433baa55de"), "Pequeña" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_IdProvincia",
                table: "Sucursales",
                column: "IdProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_IdTipo",
                table: "Sucursales",
                column: "IdTipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuraciones");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "TiposSucursal");
        }
    }
}
