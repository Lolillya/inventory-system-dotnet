using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdditionalInventorySeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Brand_ID", "BrandName", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, "Bic", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "Parker", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "Fiber Castel", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, "Staedtler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, "Faber-Castell", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, "Pentel", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, "Sharpie", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, "Expo", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, "Crayola", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, "Prismacolor", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, "Moleskine", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, "Oxford", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, "Mead", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, "Ticonderoga", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_ID", "Category_Name", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, "Art Supplies", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "Notebooks & Paper", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "Office Supplies", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, "Classroom Tools", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, "Storage & Organization", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, "Technology Accessories", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, "Science & Lab Supplies", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 1,
                columns: new[] { "Inventory_Clerk", "Inventory_Number", "Total_Quantity" },
                values: new object[] { "John Smith", 1001, 150 });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Inventory_ID", "Created_At", "Inventory_Clerk", "Inventory_Number", "Total_Quantity", "Updated_At", "Variant_ID" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sarah Johnson", 1002, 75, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mike Davis", 1003, 200, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lisa Wilson", 1004, 120, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tom Brown", 1005, 80, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 6, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Emma Taylor", 1006, 300, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6 },
                    { 7, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "John Smith", 1007, 50, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7 },
                    { 8, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sarah Johnson", 1008, 30, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8 },
                    { 9, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mike Davis", 1009, 40, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 9 },
                    { 10, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lisa Wilson", 1010, 25, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 10 },
                    { 11, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tom Brown", 1011, 60, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 11 },
                    { 12, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Emma Taylor", 1012, 100, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 12 },
                    { 13, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "John Smith", 1013, 200, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 13 },
                    { 14, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sarah Johnson", 1014, 15, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 14 },
                    { 15, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mike Davis", 1015, 25, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 15 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 1,
                column: "Description",
                value: "Smooth writing gel ink pen with 0.7mm tip");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Product_ID", "Brand_ID", "Category_ID", "CreatedAt", "Description", "Product_Code", "Product_Name", "UpdatedAt", "Variant_ID" },
                values: new object[,]
                {
                    { 2, 2, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic ballpoint pen with smooth writing", "BIC-CRYSTAL-BLK", "Bic Crystal Ballpoint Pen - Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 3, 7, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fast-drying gel pen with precise 0.5mm tip", "PENTEL-ENERGEL-05-BLU", "Pentel EnerGel 0.5mm Gel Pen - Blue", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 4, 8, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Permanent marker with fine point for detailed work", "SHARPIE-FINE-BLK", "Sharpie Fine Point Permanent Marker - Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 5, 9, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Low-odor dry erase marker for whiteboards", "EXPO-DRY-ERASE-BLK", "Expo Dry Erase Marker - Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 6, 15, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Premium #2 pencil with soft graphite", "TICONDEROGA-2-PENCIL", "Ticonderoga #2 Pencil", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6 },
                    { 7, 10, 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic 24-count box of crayons", "CRAYOLA-24-CRAYONS", "Crayola 24-Count Crayons", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7 },
                    { 8, 11, 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Professional quality colored pencils", "PRISMACOLOR-12-PENCILS", "Prismacolor Premier Colored Pencils - 12 Count", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8 },
                    { 9, 5, 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fine-tip markers in assorted colors", "STAEDTLER-12-MARKERS", "Staedtler Triplus Fineliner - 12 Count", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 9 },
                    { 10, 6, 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "High-quality colored pencils for art projects", "FABER-CASTELL-12-PENCILS", "Faber-Castell Colored Pencils - 12 Count", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 10 },
                    { 11, 12, 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hardcover notebook with ruled pages", "MOLESKINE-CLASSIC-NOTEBOOK", "Moleskine Classic Notebook - Large", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 11 },
                    { 12, 13, 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "200-page spiral notebook with college ruled paper", "OXFORD-SPIRAL-NOTEBOOK", "Oxford Spiral Notebook - College Ruled", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 12 },
                    { 13, 14, 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "100-sheet composition book with wide ruled pages", "MEAD-COMPOSITION-BOOK", "Mead Composition Book - Wide Ruled", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 13 },
                    { 14, 2, 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Standard size staples for heavy duty staplers", "STAPLES-HEAVY-DUTY", "Heavy Duty Staples - 5000 Count", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 14 },
                    { 15, 2, 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Assorted sizes paper clips for document organization", "PAPER-CLIPS-MIXED", "Mixed Size Paper Clips - 100 Count", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 15 }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Variant_ID", "CreatedAt", "Product_ID", "UpdatedAt", "Variant_Name" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "12-Pack" },
                    { 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "3-Pack" },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "4-Pack" },
                    { 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "4-Pack Assorted Colors" },
                    { 6, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "12-Pack" },
                    { 7, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "24-Count Box" },
                    { 8, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "12-Count Set" },
                    { 9, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 9, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "12-Count Assorted" },
                    { 10, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 10, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "12-Count Set" },
                    { 11, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 11, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Large (5\" x 8.25\")" },
                    { 12, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 12, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "200 Pages" },
                    { 13, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 13, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "100 Sheets" },
                    { 14, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 14, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "5000 Count Box" },
                    { 15, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 15, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "100 Count Mixed Sizes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Brand_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Variant_ID",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_ID",
                keyValue: 1,
                columns: new[] { "Inventory_Clerk", "Inventory_Number", "Total_Quantity" },
                values: new object[] { "", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_ID",
                keyValue: 1,
                column: "Description",
                value: "Smooth writing gel ink pen");
        }
    }
}
