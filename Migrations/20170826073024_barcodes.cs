using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GiveAShitBackend.Migrations
{
    public partial class barcodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BarcodeId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Barcodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barcodes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BarcodeId",
                table: "Products",
                column: "BarcodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Barcodes_UserId",
                table: "Barcodes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Barcodes_BarcodeId",
                table: "Products",
                column: "BarcodeId",
                principalTable: "Barcodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Barcodes_BarcodeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Barcodes");

            migrationBuilder.DropIndex(
                name: "IX_Products_BarcodeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BarcodeId",
                table: "Products");
        }
    }
}
