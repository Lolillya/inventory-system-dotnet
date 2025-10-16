using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedLineItemsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubTotal",
                table: "LineItem",
                newName: "Unit_Price");

            migrationBuilder.AddColumn<decimal>(
                name: "Sub_Total",
                table: "LineItem",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sub_Total",
                table: "LineItem");

            migrationBuilder.RenameColumn(
                name: "Unit_Price",
                table: "LineItem",
                newName: "SubTotal");
        }
    }
}
