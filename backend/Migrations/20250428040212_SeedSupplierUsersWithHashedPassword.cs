using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedSupplierUsersWithHashedPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyName", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Notes", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2813ffb1-e876-4183-9621-480f02708712", 0, "ColorCopy Ltd.", "41b5702a-632f-4524-adc3-622b161713f6", "hello@colorcopy.com", true, "Sophia", "Carter", true, null, "HELLO@COLORCOPY.COM", "COLORCOPY", "Printing and copying supplies", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789009", false, "a439dd21-ceec-4f99-9600-6829b8211f9b", false, "colorcopy" },
                    { "31f025f2-60a3-4a15-8b3d-5e929e1f12f4", 0, "SmartStationers Co.", "9bd94843-af22-4be5-b7c1-0795c89f8c6d", "info@smartstationers.com", true, "Hannah", "King", true, null, "INFO@SMARTSTATIONERS.COM", "SMARTSTATIONERS", "Stationery and office supplies", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789011", false, "da111342-cb10-48c8-80f2-3370f3468e43", false, "smartstationers" },
                    { "4b33af44-e3f4-449c-becf-76dcc3b0f110", 0, "Global Offices Ltd.", "a37c40a4-1e7b-44ad-a4d1-3a76917fd82e", "info@globaloffices.com", true, "Charlotte", "Baker", true, null, "INFO@GLOBALOFFICES.COM", "GLOBALOFFICES", "International office supplies", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789019", false, "90b34228-cd8a-44fd-8de7-09d18dd05f3e", false, "globaloffices" },
                    { "56e2e671-7353-4bce-950b-b76d74915f0f", 0, "AlphaWorks Stationers", "1b867235-a6e7-4c6b-8418-e66546026902", "sales@alphaworks.com", true, "Emily", "Stewart", true, null, "SALES@ALPHAWORKS.COM", "ALPHAWORKS", "Office supplies distributor", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789007", false, "666a4160-19a6-430d-896b-9edd6f61a21c", false, "alphaworks" },
                    { "5cc99ded-fe07-4bbb-a761-4a6025891f9f", 0, "BrightBooks Inc.", "cc8a4155-0a2e-45b9-8cd1-8627269b3ba5", "info@brightbooks.com", true, "Jason", "Lee", true, null, "INFO@BRIGHTBOOKS.COM", "BRIGHTBOOKS", "Book and educational materials supplier", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789008", false, "cc8a4155-0a2e-45b9-8cd1-8627269b3ba5", false, "brightbooks" },
                    { "64bc2df7-a283-40c6-aa76-cc79d5d2378a", 0, "Prime Papers Corporation", "6aab628a-68f4-4e7e-95a3-03c42897f849", "orders@primepapers.com", true, "Isabella", "Green", true, null, "ORDERS@PRIMEPAPERS.COM", "PRIMEPAPERS", "Paper products supplier", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789017", false, "56358e25-aa23-4266-8a1a-c38a81e799e7", false, "primepapers" },
                    { "a7f1f87f-8150-4c86-bef3-3b6f5b497c0b", 0, "FastPrint Solutions", "bb9bd41a-5582-49d2-be6e-3f576cefbbcb", "support@fastprint.com", true, "Daniel", "Young", true, null, "SUPPORT@FASTPRINT.COM", "FASTPRINT", "Printing and stationery supplier", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789006", false, "27f0738f-c40d-4766-be53-a6f42defc331", false, "fastprint" },
                    { "acef761f-019a-4ca2-982a-d8e7dee767ed", 0, "Primo Educational Supplies", "9d9977ed-ea32-4ab2-832b-0b70dd82e5a6", "orders@primoeducational.com", true, "Ava", "White", true, null, "ORDERS@PRIMOEDUCATIONAL.COM", "PRIMOEDUCATIONAL", "Educational supplies distributor", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789013", false, "a56c84c8-2d13-4243-8e53-9cb37ecdf9a8", false, "primoeducational" },
                    { "be61d1f3-dfc4-4c60-bbc2-0136ae5cfb5c", 0, "BrightTech Office Supplies", "2b963347-0568-4532-ba63-bff4d948f7b0", "sales@brighttech.com", true, "William", "Scott", true, null, "SALES@BRIGHTTECH.COM", "BRIGHTTECH", "Office technology and supplies", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789016", false, "818c6e97-8d4b-47a6-a61c-6cf55fd61312", false, "brighttech" },
                    { "dd83701a-3664-44a0-b813-85d5e80532da", 0, "AceOffice Supplies", "f56a3acc-f5e2-4dec-9d3c-62b6312f33cd", "sales@aceoffice.com", true, "Lucas", "Mitchell", true, null, "SALES@ACEOFFICE.COM", "ACEOFFICE", "Premium office supplies", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789020", false, "083ec1d5-0395-4aed-86d4-4facf40f7b64", false, "aceoffice" },
                    { "e1615701-0602-4f0b-8815-c486c5e5fde0", 0, "Xpress Stationery Services", "a6c7ada1-0576-48f0-a02f-5e6a625da32b", "support@xpressstationery.com", true, "James", "Wright", true, null, "SUPPORT@XPRESSSTATIONERY.COM", "XPRESSSTATIONERY", "Fast delivery stationery service", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789018", false, "e165ed1d-714e-4ebb-b81d-5823294e1934", false, "xpressstationery" },
                    { "e4f938e4-e3fc-4fe3-94d4-4a664de76e0d", 0, "EcoPaper Plus", "ef2f7100-d8b9-4e69-a8a3-7a449275eca6", "eco@ecopaperplus.com", true, "Mia", "Hill", true, null, "ECO@ECOPAPERPLUS.COM", "ECOPAPERPLUS", "Eco-friendly paper products", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789014", false, "9bb73ee2-e28f-4711-9042-c9c1c29980d4", false, "ecopaperplus" },
                    { "eba6a85d-944e-42af-b963-1a22b2c66bfc", 0, "Offix Solutions", "9cc56f99-01cf-442a-b397-93314ca67483", "support@offixsolutions.com", true, "Jacob", "Moore", true, null, "SUPPORT@OFFIXSOLUTIONS.COM", "OFFIXSOLUTIONS", "Office solutions provider", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789012", false, "d777e1f8-9893-48f4-8d00-93300ba89ad2", false, "offixsolutions" },
                    { "f542b6c8-24f1-4dbe-8a1c-05866a020016", 0, "NextGen Office Equipment", "0b6683fb-059b-47f4-9457-41343c974d95", "contact@nextgenoffice.com", true, "Ryan", "Turner", true, null, "CONTACT@NEXTGENOFFICE.COM", "NEXTGENOFFICE", "Office equipment and supplies", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789010", false, "016609ef-88be-4c47-be8f-d417310834f0", false, "nextgenoffice" },
                    { "fd9249ce-169c-457f-8513-7ada0ac1683b", 0, "EduSmart Stationery", "bb9a82b4-064d-4a1c-92b6-3982f074afcb", "hello@edusmart.com", true, "Noah", "Adams", true, null, "HELLO@EDUSMART.COM", "EDUSMART", "Educational stationery supplier", "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C", "3456789015", false, "be7551f4-6ea9-40cc-b337-1c2c6db91faf", false, "edusmart" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "2813ffb1-e876-4183-9621-480f02708712" },
                    { "3", "31f025f2-60a3-4a15-8b3d-5e929e1f12f4" },
                    { "3", "4b33af44-e3f4-449c-becf-76dcc3b0f110" },
                    { "3", "56e2e671-7353-4bce-950b-b76d74915f0f" },
                    { "3", "5cc99ded-fe07-4bbb-a761-4a6025891f9f" },
                    { "3", "64bc2df7-a283-40c6-aa76-cc79d5d2378a" },
                    { "3", "a7f1f87f-8150-4c86-bef3-3b6f5b497c0b" },
                    { "3", "acef761f-019a-4ca2-982a-d8e7dee767ed" },
                    { "3", "be61d1f3-dfc4-4c60-bbc2-0136ae5cfb5c" },
                    { "3", "dd83701a-3664-44a0-b813-85d5e80532da" },
                    { "3", "e1615701-0602-4f0b-8815-c486c5e5fde0" },
                    { "3", "e4f938e4-e3fc-4fe3-94d4-4a664de76e0d" },
                    { "3", "eba6a85d-944e-42af-b963-1a22b2c66bfc" },
                    { "3", "f542b6c8-24f1-4dbe-8a1c-05866a020016" },
                    { "3", "fd9249ce-169c-457f-8513-7ada0ac1683b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "2813ffb1-e876-4183-9621-480f02708712" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "31f025f2-60a3-4a15-8b3d-5e929e1f12f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "4b33af44-e3f4-449c-becf-76dcc3b0f110" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "56e2e671-7353-4bce-950b-b76d74915f0f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "5cc99ded-fe07-4bbb-a761-4a6025891f9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "64bc2df7-a283-40c6-aa76-cc79d5d2378a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "a7f1f87f-8150-4c86-bef3-3b6f5b497c0b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "acef761f-019a-4ca2-982a-d8e7dee767ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "be61d1f3-dfc4-4c60-bbc2-0136ae5cfb5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "dd83701a-3664-44a0-b813-85d5e80532da" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "e1615701-0602-4f0b-8815-c486c5e5fde0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "e4f938e4-e3fc-4fe3-94d4-4a664de76e0d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "eba6a85d-944e-42af-b963-1a22b2c66bfc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "f542b6c8-24f1-4dbe-8a1c-05866a020016" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "fd9249ce-169c-457f-8513-7ada0ac1683b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2813ffb1-e876-4183-9621-480f02708712");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31f025f2-60a3-4a15-8b3d-5e929e1f12f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b33af44-e3f4-449c-becf-76dcc3b0f110");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56e2e671-7353-4bce-950b-b76d74915f0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cc99ded-fe07-4bbb-a761-4a6025891f9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64bc2df7-a283-40c6-aa76-cc79d5d2378a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7f1f87f-8150-4c86-bef3-3b6f5b497c0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acef761f-019a-4ca2-982a-d8e7dee767ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be61d1f3-dfc4-4c60-bbc2-0136ae5cfb5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd83701a-3664-44a0-b813-85d5e80532da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1615701-0602-4f0b-8815-c486c5e5fde0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4f938e4-e3fc-4fe3-94d4-4a664de76e0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eba6a85d-944e-42af-b963-1a22b2c66bfc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f542b6c8-24f1-4dbe-8a1c-05866a020016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9249ce-169c-457f-8513-7ada0ac1683b");

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
    }
}
