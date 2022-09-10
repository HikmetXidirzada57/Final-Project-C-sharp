using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class reeferances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TagtoProducts_ProductId",
                table: "TagtoProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TagtoProducts_TagId",
                table: "TagtoProducts",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpesifications_ProductId",
                table: "ProductSpesifications",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpesifications_SpesificationId",
                table: "ProductSpesifications",
                column: "SpesificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpesifications_Products_ProductId",
                table: "ProductSpesifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpesifications_Spesifications_SpesificationId",
                table: "ProductSpesifications",
                column: "SpesificationId",
                principalTable: "Spesifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagtoProducts_Products_ProductId",
                table: "TagtoProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagtoProducts_Tags_TagId",
                table: "TagtoProducts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpesifications_Products_ProductId",
                table: "ProductSpesifications");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpesifications_Spesifications_SpesificationId",
                table: "ProductSpesifications");

            migrationBuilder.DropForeignKey(
                name: "FK_TagtoProducts_Products_ProductId",
                table: "TagtoProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_TagtoProducts_Tags_TagId",
                table: "TagtoProducts");

            migrationBuilder.DropIndex(
                name: "IX_TagtoProducts_ProductId",
                table: "TagtoProducts");

            migrationBuilder.DropIndex(
                name: "IX_TagtoProducts_TagId",
                table: "TagtoProducts");

            migrationBuilder.DropIndex(
                name: "IX_ProductSpesifications_ProductId",
                table: "ProductSpesifications");

            migrationBuilder.DropIndex(
                name: "IX_ProductSpesifications_SpesificationId",
                table: "ProductSpesifications");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
