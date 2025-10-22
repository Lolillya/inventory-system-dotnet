using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class FixDuplicateRestock_ID2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID",
                table: "RestockLineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID1",
                table: "RestockLineItems");

            migrationBuilder.DropIndex(
                name: "IX_RestockLineItems_Restock_ID1",
                table: "RestockLineItems");

            migrationBuilder.DropColumn(
                name: "Restock_ID1",
                table: "RestockLineItems");

            migrationBuilder.AddForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID",
                table: "RestockLineItems",
                column: "Restock_ID",
                principalTable: "Restock",
                principalColumn: "Restock_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID",
                table: "RestockLineItems");

            migrationBuilder.AddColumn<int>(
                name: "Restock_ID1",
                table: "RestockLineItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestockLineItems_Restock_ID1",
                table: "RestockLineItems",
                column: "Restock_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID",
                table: "RestockLineItems",
                column: "Restock_ID",
                principalTable: "Restock",
                principalColumn: "Restock_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID1",
                table: "RestockLineItems",
                column: "Restock_ID1",
                principalTable: "Restock",
                principalColumn: "Restock_ID");
        }
    }
}
