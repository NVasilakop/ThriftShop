using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThriftShop.Migrations
{
    public partial class productImageAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductDetails",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductImageId",
                table: "ProductDetails",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    ProductImageId = table.Column<Guid>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.ProductImageId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductImageId",
                table: "ProductDetails",
                column: "ProductImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_ProductImage_ProductImageId",
                table: "ProductDetails",
                column: "ProductImageId",
                principalTable: "ProductImage",
                principalColumn: "ProductImageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_ProductImage_ProductImageId",
                table: "ProductDetails");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_ProductImageId",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "ProductDetails");
        }
    }
}
