using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "motos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placa = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    marca = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    linea = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cilindraje = table.Column<int>(type: "int", nullable: true),
                    modelo = table.Column<int>(type: "int", nullable: true),
                    precio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__motos__3213E83F21962CE0", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "spVentasListar",
                columns: table => new
                {
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cilindraje = table.Column<int>(type: "int", nullable: false),
                    modelo = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tipoDocumento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tipoDocu__3213E83F205C5DE0", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipoPago",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tipoPago__3213E83FCE9C1944", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ventas",
                columns: table => new
                {
                    idVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    tipoPago = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<int>(type: "int", nullable: false),
                    idMoto = table.Column<int>(type: "int", nullable: false),
                    idVendedor = table.Column<int>(type: "int", nullable: false),
                    nombreVendedor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    apellidoVendedor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    tipoDocumento = table.Column<int>(type: "int", nullable: false),
                    numeroDocumento = table.Column<int>(type: "int", nullable: false),
                    nombreCliente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    apellidoCliente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    correoCliente = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ventas__077D561405C3179D", x => x.idVenta);
                    table.ForeignKey(
                        name: "FK__ventas__idMoto__70DDC3D8",
                        column: x => x.idMoto,
                        principalTable: "motos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "PlacaUnica",
                table: "motos",
                column: "placa",
                unique: true,
                filter: "[placa] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "CorreoUnico",
                table: "ventas",
                column: "correoCliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ventas_idMoto",
                table: "ventas",
                column: "idMoto");

            migrationBuilder.CreateIndex(
                name: "UQ__ventas__F987A964FDF6F11A",
                table: "ventas",
                column: "correoCliente",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "spVentasListar");

            migrationBuilder.DropTable(
                name: "tipoDocumento");

            migrationBuilder.DropTable(
                name: "tipoPago");

            migrationBuilder.DropTable(
                name: "ventas");

            migrationBuilder.DropTable(
                name: "motos");
        }
    }
}
