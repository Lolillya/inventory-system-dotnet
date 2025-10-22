using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class FixDuplicateRestock_ID3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID",
                table: "RestockLineItems");

            migrationBuilder.AddForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID",
                table: "RestockLineItems",
                column: "Restock_ID",
                principalTable: "Restock",
                principalColumn: "Restock_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID",
                table: "RestockLineItems");

            migrationBuilder.AddForeignKey(
                name: "FK_RestockLineItems_Restock_Restock_ID",
                table: "RestockLineItems",
                column: "Restock_ID",
                principalTable: "Restock",
                principalColumn: "Restock_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
