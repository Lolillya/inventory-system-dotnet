using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedSupplierUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyName", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Notes", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32de9075-214f-4a8d-913f-a131168d4853", 0, "BrightBooks Inc.", "c8f18374-487c-4c01-856a-c7cba8cce9c2", "info@brightbooks.com", true, "Jason", "Lee", true, null, "INFO@BRIGHTBOOKS.COM", "BRIGHTBOOKS", "Book and educational materials supplier", null, "3456789008", false, "47fd52f9-0c91-4971-aac8-4a46e98c3728", false, "brightbooks" },
                    { "5317870b-36fd-400c-8657-dbc43b17e5e7", 0, "AlphaWorks Stationers", "910415f2-6ac4-4114-a762-df9b5ed35aca", "sales@alphaworks.com", true, "Emily", "Stewart", true, null, "SALES@ALPHAWORKS.COM", "ALPHAWORKS", "Office supplies distributor", null, "3456789007", false, "c0b77d40-e130-4c6f-a551-e98a1b933ef8", false, "alphaworks" },
                    { "586f91a5-f77a-4e3e-a5a9-fe042d1ae8bd", 0, "Xpress Stationery Services", "0c667dc4-2381-4830-ad20-40bcc6884a40", "support@xpressstationery.com", true, "James", "Wright", true, null, "SUPPORT@XPRESSSTATIONERY.COM", "XPRESSSTATIONERY", "Fast delivery stationery service", null, "3456789018", false, "cbaae800-af1d-49b6-9db9-f80a079fa81e", false, "xpressstationery" },
                    { "64512944-ff2b-42ef-bb8f-2ee8e3a79ddb", 0, "EcoPaper Plus", "d0963a43-a4a1-4860-803b-77037da9a6d8", "eco@ecopaperplus.com", true, "Mia", "Hill", true, null, "ECO@ECOPAPERPLUS.COM", "ECOPAPERPLUS", "Eco-friendly paper products", null, "3456789014", false, "1ad80928-6f0f-417c-815b-546e5e2d0db5", false, "ecopaperplus" },
                    { "751d4c9f-e532-430f-abff-8e4e4b6b8a82", 0, "BrightTech Office Supplies", "44c2b280-6c85-4936-8791-3c7e3ce0c4c5", "sales@brighttech.com", true, "William", "Scott", true, null, "SALES@BRIGHTTECH.COM", "BRIGHTTECH", "Office technology and supplies", null, "3456789016", false, "1c5ac639-a3af-468a-a83d-b07e16d5c49e", false, "brighttech" },
                    { "8a0eaedd-53bc-47b0-bf49-f742e2540e89", 0, "Global Offices Ltd.", "eafb4b35-3e50-46ee-aff3-55e4db396f59", "info@globaloffices.com", true, "Charlotte", "Baker", true, null, "INFO@GLOBALOFFICES.COM", "GLOBALOFFICES", "International office supplies", null, "3456789019", false, "12271fda-aae7-4872-b250-eb7ecdf359d7", false, "globaloffices" },
                    { "a95f66e0-bc8b-402f-a5f5-8fd51a7985d5", 0, "NextGen Office Equipment", "7d0bc8a1-7d10-45f6-8ebe-aa1a313dae3c", "contact@nextgenoffice.com", true, "Ryan", "Turner", true, null, "CONTACT@NEXTGENOFFICE.COM", "NEXTGENOFFICE", "Office equipment and supplies", null, "3456789010", false, "151bd860-fd6b-4d8a-ab62-64a8777d4e52", false, "nextgenoffice" },
                    { "b1909819-071a-4a5b-aa1f-38b737e0a133", 0, "Offix Solutions", "841ddbcd-ecca-461f-88d2-f83bab7b2448", "support@offixsolutions.com", true, "Jacob", "Moore", true, null, "SUPPORT@OFFIXSOLUTIONS.COM", "OFFIXSOLUTIONS", "Office solutions provider", null, "3456789012", false, "d06c2f2b-fa5d-4a1c-a084-2c710186e094", false, "offixsolutions" },
                    { "b507cdc0-8846-40fe-90ae-dcda5110eeab", 0, "Primo Educational Supplies", "48c92c6c-1d8f-4689-b179-3de9569f353f", "orders@primoeducational.com", true, "Ava", "White", true, null, "ORDERS@PRIMOEDUCATIONAL.COM", "PRIMOEDUCATIONAL", "Educational supplies distributor", null, "3456789013", false, "42a20668-1632-410d-844a-3cccf3d7c9a5", false, "primoeducational" },
                    { "bcd34ec7-52da-44a6-b592-5dd78b38ca9d", 0, "EduSmart Stationery", "a36d5fbf-a32a-41c8-8b7c-729ca9f5b8b0", "hello@edusmart.com", true, "Noah", "Adams", true, null, "HELLO@EDUSMART.COM", "EDUSMART", "Educational stationery supplier", null, "3456789015", false, "3dbde75d-bc3f-473e-861c-fef4838691fb", false, "edusmart" },
                    { "c23fc550-0896-4d4d-90e9-89ed6cb2e394", 0, "Prime Papers Corporation", "7a12cf6f-2d76-4c2e-984a-36c9d2876aad", "orders@primepapers.com", true, "Isabella", "Green", true, null, "ORDERS@PRIMEPAPERS.COM", "PRIMEPAPERS", "Paper products supplier", null, "3456789017", false, "c5878810-e386-4330-bed8-539a9936310f", false, "primepapers" },
                    { "c8704368-0f52-4aaa-ae0c-e39a164e6e7a", 0, "AceOffice Supplies", "15af3825-9e03-44ad-8d24-514cda885914", "sales@aceoffice.com", true, "Lucas", "Mitchell", true, null, "SALES@ACEOFFICE.COM", "ACEOFFICE", "Premium office supplies", null, "3456789020", false, "bdd94ba1-6450-4092-86c0-97bb4571b228", false, "aceoffice" },
                    { "ce488c37-45b6-4d69-8a64-d02fa9a61894", 0, "ColorCopy Ltd.", "f9e638d8-06a9-494c-b6a7-733f2deb92e8", "hello@colorcopy.com", true, "Sophia", "Carter", true, null, "HELLO@COLORCOPY.COM", "COLORCOPY", "Printing and copying supplies", null, "3456789009", false, "790282c0-6de7-4551-8010-b4ff51aaef0f", false, "colorcopy" },
                    { "d8833b71-7bad-478e-8189-d2cbfab8ac5e", 0, "FastPrint Solutions", "23bd17b5-a873-45f5-869e-296b3fb982d7", "support@fastprint.com", true, "Daniel", "Young", true, null, "SUPPORT@FASTPRINT.COM", "FASTPRINT", "Printing and stationery supplier", null, "3456789006", false, "b6dcd800-afd7-4800-914c-9bdb89b20a40", false, "fastprint" },
                    { "ecb61b82-b1d4-488f-8736-c3d248378713", 0, "SmartStationers Co.", "e98a2e1e-bc42-4e99-8552-2c069f58a053", "info@smartstationers.com", true, "Hannah", "King", true, null, "INFO@SMARTSTATIONERS.COM", "SMARTSTATIONERS", "Stationery and office supplies", null, "3456789011", false, "9d93befb-ea58-4d0f-ba52-76ae758f214d", false, "smartstationers" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "32de9075-214f-4a8d-913f-a131168d4853" },
                    { "3", "5317870b-36fd-400c-8657-dbc43b17e5e7" },
                    { "3", "586f91a5-f77a-4e3e-a5a9-fe042d1ae8bd" },
                    { "3", "64512944-ff2b-42ef-bb8f-2ee8e3a79ddb" },
                    { "3", "751d4c9f-e532-430f-abff-8e4e4b6b8a82" },
                    { "3", "8a0eaedd-53bc-47b0-bf49-f742e2540e89" },
                    { "3", "a95f66e0-bc8b-402f-a5f5-8fd51a7985d5" },
                    { "3", "b1909819-071a-4a5b-aa1f-38b737e0a133" },
                    { "3", "b507cdc0-8846-40fe-90ae-dcda5110eeab" },
                    { "3", "bcd34ec7-52da-44a6-b592-5dd78b38ca9d" },
                    { "3", "c23fc550-0896-4d4d-90e9-89ed6cb2e394" },
                    { "3", "c8704368-0f52-4aaa-ae0c-e39a164e6e7a" },
                    { "3", "ce488c37-45b6-4d69-8a64-d02fa9a61894" },
                    { "3", "d8833b71-7bad-478e-8189-d2cbfab8ac5e" },
                    { "3", "ecb61b82-b1d4-488f-8736-c3d248378713" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "32de9075-214f-4a8d-913f-a131168d4853" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "5317870b-36fd-400c-8657-dbc43b17e5e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "586f91a5-f77a-4e3e-a5a9-fe042d1ae8bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "64512944-ff2b-42ef-bb8f-2ee8e3a79ddb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "751d4c9f-e532-430f-abff-8e4e4b6b8a82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "8a0eaedd-53bc-47b0-bf49-f742e2540e89" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "a95f66e0-bc8b-402f-a5f5-8fd51a7985d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "b1909819-071a-4a5b-aa1f-38b737e0a133" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "b507cdc0-8846-40fe-90ae-dcda5110eeab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "bcd34ec7-52da-44a6-b592-5dd78b38ca9d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "c23fc550-0896-4d4d-90e9-89ed6cb2e394" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "c8704368-0f52-4aaa-ae0c-e39a164e6e7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "ce488c37-45b6-4d69-8a64-d02fa9a61894" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d8833b71-7bad-478e-8189-d2cbfab8ac5e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "ecb61b82-b1d4-488f-8736-c3d248378713" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32de9075-214f-4a8d-913f-a131168d4853");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5317870b-36fd-400c-8657-dbc43b17e5e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "586f91a5-f77a-4e3e-a5a9-fe042d1ae8bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64512944-ff2b-42ef-bb8f-2ee8e3a79ddb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "751d4c9f-e532-430f-abff-8e4e4b6b8a82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a0eaedd-53bc-47b0-bf49-f742e2540e89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a95f66e0-bc8b-402f-a5f5-8fd51a7985d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1909819-071a-4a5b-aa1f-38b737e0a133");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b507cdc0-8846-40fe-90ae-dcda5110eeab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcd34ec7-52da-44a6-b592-5dd78b38ca9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c23fc550-0896-4d4d-90e9-89ed6cb2e394");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8704368-0f52-4aaa-ae0c-e39a164e6e7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce488c37-45b6-4d69-8a64-d02fa9a61894");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8833b71-7bad-478e-8189-d2cbfab8ac5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecb61b82-b1d4-488f-8736-c3d248378713");
        }
    }
}
