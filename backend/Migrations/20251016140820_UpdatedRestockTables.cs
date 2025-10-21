using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRestockTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineItem_Products_Product_ID",
                table: "LineItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Restock_LineItem_LineItem_ID",
                table: "Restock");

            migrationBuilder.DropIndex(
                name: "IX_Restock_LineItem_ID",
                table: "Restock");

            migrationBuilder.DropColumn(
                name: "Restock_ID",
                table: "RestocksBatch");

            migrationBuilder.DropColumn(
                name: "LineItem_ID",
                table: "Restock");

            migrationBuilder.RenameColumn(
                name: "SubTotal",
                table: "LineItem",
                newName: "Unit_Price");

            migrationBuilder.AddColumn<decimal>(
                name: "LineItems_Total",
                table: "Restock",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Restock_ID",
                table: "LineItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Sub_Total",
                table: "LineItem",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_Restock_ID",
                table: "LineItem",
                column: "Restock_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_LineItem_Products_Product_ID",
                table: "LineItem",
                column: "Product_ID",
                principalTable: "Products",
                principalColumn: "Product_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_LineItem_Restock_Restock_ID",
                table: "LineItem",
                column: "Restock_ID",
                principalTable: "Restock",
                principalColumn: "Restock_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineItem_Products_Product_ID",
                table: "LineItem");

            migrationBuilder.DropForeignKey(
                name: "FK_LineItem_Restock_Restock_ID",
                table: "LineItem");

            migrationBuilder.DropIndex(
                name: "IX_LineItem_Restock_ID",
                table: "LineItem");

            migrationBuilder.DropColumn(
                name: "LineItems_Total",
                table: "Restock");

            migrationBuilder.DropColumn(
                name: "Restock_ID",
                table: "LineItem");

            migrationBuilder.DropColumn(
                name: "Sub_Total",
                table: "LineItem");

            migrationBuilder.RenameColumn(
                name: "Unit_Price",
                table: "LineItem",
                newName: "SubTotal");

            migrationBuilder.AddColumn<int>(
                name: "Restock_ID",
                table: "RestocksBatch",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LineItem_ID",
                table: "Restock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Restock_LineItem_ID",
                table: "Restock",
                column: "LineItem_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_LineItem_Products_Product_ID",
                table: "LineItem",
                column: "Product_ID",
                principalTable: "Products",
                principalColumn: "Product_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Restock_LineItem_LineItem_ID",
                table: "Restock",
                column: "LineItem_ID",
                principalTable: "LineItem",
                principalColumn: "LineItem_ID");
        }
    }
}
