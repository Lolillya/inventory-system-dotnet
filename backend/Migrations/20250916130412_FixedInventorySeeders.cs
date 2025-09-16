using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class FixedInventorySeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 1,
                columns: new[] { "Category_Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Writing Instruments", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Product_Code", "Product_Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Smooth writing gel ink pen", "PILOT-G2-07-BLK", "Pilot G2 0.7 Gel Pen - Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "Variant_Name" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Single Pack" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 16, 13, 0, 24, 903, DateTimeKind.Utc).AddTicks(8894), new DateTime(2025, 9, 16, 13, 0, 24, 903, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 1,
                columns: new[] { "Category_Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "", new DateTime(2025, 9, 16, 13, 0, 24, 904, DateTimeKind.Utc).AddTicks(3094), new DateTime(2025, 9, 16, 13, 0, 24, 904, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 9, 16, 13, 0, 24, 905, DateTimeKind.Utc).AddTicks(2162), new DateTime(2025, 9, 16, 13, 0, 24, 905, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Product_Code", "Product_Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 16, 13, 0, 24, 904, DateTimeKind.Utc).AddTicks(7931), "", "", "", new DateTime(2025, 9, 16, 13, 0, 24, 904, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "Variant_Name" },
                values: new object[] { new DateTime(2025, 9, 16, 13, 0, 24, 905, DateTimeKind.Utc).AddTicks(5208), new DateTime(2025, 9, 16, 13, 0, 24, 905, DateTimeKind.Utc).AddTicks(5359), "" });
        }
    }
}
