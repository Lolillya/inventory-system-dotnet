using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedRestocksModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LineItem",
                columns: table => new
                {
                    LineItem_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItem", x => x.LineItem_ID);
                    table.ForeignKey(
                        name: "FK_LineItem_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestocksBatch",
                columns: table => new
                {
                    Batch_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Batch_Number = table.Column<int>(type: "int", nullable: false),
                    Restock_ID = table.Column<int>(type: "int", nullable: false),
                    Supplier_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestocksBatch", x => x.Batch_ID);
                    table.ForeignKey(
                        name: "FK_RestocksBatch_AspNetUsers_Supplier_ID",
                        column: x => x.Supplier_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restock",
                columns: table => new
                {
                    Restock_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineItem_ID = table.Column<int>(type: "int", nullable: false),
                    Batch_ID = table.Column<int>(type: "int", nullable: false),
                    Restock_Clerk = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restock", x => x.Restock_ID);
                    table.ForeignKey(
                        name: "FK_Restock_AspNetUsers_Restock_Clerk",
                        column: x => x.Restock_Clerk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restock_LineItem_LineItem_ID",
                        column: x => x.LineItem_ID,
                        principalTable: "LineItem",
                        principalColumn: "LineItem_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_Product_ID",
                table: "LineItem",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Restock_LineItem_ID",
                table: "Restock",
                column: "LineItem_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Restock_Restock_Clerk",
                table: "Restock",
                column: "Restock_Clerk");

            migrationBuilder.CreateIndex(
                name: "IX_RestocksBatch_Supplier_ID",
                table: "RestocksBatch",
                column: "Supplier_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restock");

            migrationBuilder.DropTable(
                name: "RestocksBatch");

            migrationBuilder.DropTable(
                name: "LineItem");
        }
    }
}
