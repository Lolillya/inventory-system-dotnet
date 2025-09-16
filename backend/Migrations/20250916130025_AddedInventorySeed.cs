using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedInventorySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Brand_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Brand_ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Inventory_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Variant_ID = table.Column<int>(type: "int", nullable: false),
                    Total_Quantity = table.Column<int>(type: "int", nullable: false),
                    Inventory_Number = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inventory_Clerk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Inventory_ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand_ID = table.Column<int>(type: "int", nullable: false),
                    Category_ID = table.Column<int>(type: "int", nullable: false),
                    Variant_ID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_ID);
                });

            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    Variant_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Variant_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.Variant_ID);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Brand_ID", "BrandName", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, "Pilot", new DateTime(2025, 9, 16, 13, 0, 24, 903, DateTimeKind.Utc).AddTicks(8894), new DateTime(2025, 9, 16, 13, 0, 24, 903, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_ID", "Category_Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, "", new DateTime(2025, 9, 16, 13, 0, 24, 904, DateTimeKind.Utc).AddTicks(3094), new DateTime(2025, 9, 16, 13, 0, 24, 904, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Inventory_ID", "Created_At", "Inventory_Clerk", "Inventory_Number", "Total_Quantity", "Updated_At", "Variant_ID" },
                values: new object[] { 1, new DateTime(2025, 9, 16, 13, 0, 24, 905, DateTimeKind.Utc).AddTicks(2162), "", 0, 0, new DateTime(2025, 9, 16, 13, 0, 24, 905, DateTimeKind.Utc).AddTicks(2343), 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Product_ID", "Brand_ID", "Category_ID", "CreatedAt", "Description", "Product_Code", "Product_Name", "UpdatedAt", "Variant_ID" },
                values: new object[] { 1, 1, 1, new DateTime(2025, 9, 16, 13, 0, 24, 904, DateTimeKind.Utc).AddTicks(7931), "", "", "", new DateTime(2025, 9, 16, 13, 0, 24, 904, DateTimeKind.Utc).AddTicks(8205), 1 });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Variant_ID", "CreatedAt", "Product_ID", "UpdatedAt", "Variant_Name" },
                values: new object[] { 1, new DateTime(2025, 9, 16, 13, 0, 24, 905, DateTimeKind.Utc).AddTicks(5208), 1, new DateTime(2025, 9, 16, 13, 0, 24, 905, DateTimeKind.Utc).AddTicks(5359), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Variants");
        }
    }
}
