using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyName", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Notes", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "Prince Educational Supply", "8d5e6f7a-1b2c-3d4e-5f6a-7b8c9d0e1f2a", "admin@prince.edu", true, "System", "Administrator", true, null, "ADMIN@PRINCE.EDU", "ADMIN", "System Administrator Account", "AQAAAAIAAYagAAAAECi2K4eHcjTVE7qsEp104bIepbLLOy79iOa6BkfehV641hJfh8NLCW77cgEr8mjUng==", "1234567890", false, "7c4c8c0a-9b3a-4e5f-9d1c-1a2b3c4d5e6f", false, "admin" },
                    { "2", 0, "Prince Educational Supply", "0e1f2a3b-4c5d-6e7f-8a9b-0c1d2e3f4a5b", "employee@prince.edu", true, "John", "Doe", true, null, "EMPLOYEE@PRINCE.EDU", "EMPLOYEE", "Inventory Manager", "AQAAAAIAAYagAAAAEB9XAht9KYSL1BZX0PdlCQ9/Km+aZf3R5Kh2p0pSEmu1WXrrkWlKzE96EYjGBdYYTg==", "2345678901", false, "9d0e1f2a-3b4c-5d6e-7f8a-9b0c1d2e3f4a", false, "employee" },
                    { "3", 0, "Educational Supplies Inc.", "2a3b4c5d-6e7f-8a9b-0c1d-2e3f4a5b6c7d", "supplier@example.com", true, "Jane", "Smith", true, null, "SUPPLIER@EXAMPLE.COM", "SUPPLIER", "Main supplier of stationery", "AQAAAAIAAYagAAAAEMtx6ETMAiWY2d2duJC3yWv5O1ln4BmblsfsY0RtBdhMYlHw1sbVoiLEGKZMKdBW2Q==", "3456789012", false, "1f2a3b4c-5d6e-7f8a-9b0c-1d2e3f4a5b6c", false, "supplier" },
                    { "4", 0, "Johnson Elementary School", "4c5d6e7f-8a9b-0c1d-2e3f-4a5b6c7d8e9f", "customer@example.com", true, "Robert", "Johnson", true, null, "CUSTOMER@EXAMPLE.COM", "CUSTOMER", "Regular customer - monthly orders", "AQAAAAIAAYagAAAAECYdyHpEuNGiqJd55P+ZO7BdKkSqxuddv3TordSoeyK39SMzSO1LQP5LW6CSIct1ww==", "4567890123", false, "3b4c5d6e-7f8a-9b0c-1d2e-3f4a5b6c7d8e", false, "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" },
                    { "4", "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");
        }
    }
}
