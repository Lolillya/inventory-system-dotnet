using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedLineItemsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineItem");

            migrationBuilder.CreateTable(
                name: "InvoiceLineItems",
                columns: table => new
                {
                    LineItem_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Invoice_ID = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sub_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceLineItems", x => x.LineItem_ID);
                    table.ForeignKey(
                        name: "FK_InvoiceLineItems_Invoice_Invoice_ID",
                        column: x => x.Invoice_ID,
                        principalTable: "Invoice",
                        principalColumn: "Invoice_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceLineItems_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestockLineItems",
                columns: table => new
                {
                    LineItem_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Restock_ID = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sub_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Restock_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestockLineItems", x => x.LineItem_ID);
                    table.ForeignKey(
                        name: "FK_RestockLineItems_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID");
                    table.ForeignKey(
                        name: "FK_RestockLineItems_Restock_Restock_ID",
                        column: x => x.Restock_ID,
                        principalTable: "Restock",
                        principalColumn: "Restock_ID");
                    table.ForeignKey(
                        name: "FK_RestockLineItems_Restock_Restock_ID1",
                        column: x => x.Restock_ID1,
                        principalTable: "Restock",
                        principalColumn: "Restock_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLineItems_Invoice_ID",
                table: "InvoiceLineItems",
                column: "Invoice_ID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLineItems_Product_ID",
                table: "InvoiceLineItems",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RestockLineItems_Product_ID",
                table: "RestockLineItems",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RestockLineItems_Restock_ID",
                table: "RestockLineItems",
                column: "Restock_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RestockLineItems_Restock_ID1",
                table: "RestockLineItems",
                column: "Restock_ID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceLineItems");

            migrationBuilder.DropTable(
                name: "RestockLineItems");

            migrationBuilder.CreateTable(
                name: "LineItem",
                columns: table => new
                {
                    LineItem_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Restock_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Sub_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItem", x => x.LineItem_ID);
                    table.ForeignKey(
                        name: "FK_LineItem_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID");
                    table.ForeignKey(
                        name: "FK_LineItem_Restock_Restock_ID",
                        column: x => x.Restock_ID,
                        principalTable: "Restock",
                        principalColumn: "Restock_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_Product_ID",
                table: "LineItem",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_Restock_ID",
                table: "LineItem",
                column: "Restock_ID");
        }
    }
}
