using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "$2a$12$jp5zIIJOL8xuwDJ8iFQ71eCo8SkyYUe.EzycyKo9x8avU63OE./DK");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "PasswordHash",
                value: "$2a$12$ftZOEZ3bCuHwb8sY3q4TK.9842WEhzdptOPQdDGYnfyFt0Wr.Fhbi");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "PasswordHash",
                value: "$2a$12$ycj3WiWbM50s0umHkb3ZmuX9BHbrfhmZm8Ps58grA/E2GdF2BG1Ge");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "PasswordHash",
                value: "$2a$12$qg9Dg6MBwphaDdYWImxO7O8pwjz9NWz28r9hGiCWnDLtVa0ynK9W2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECi2K4eHcjTVE7qsEp104bIepbLLOy79iOa6BkfehV641hJfh8NLCW77cgEr8mjUng==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB9XAht9KYSL1BZX0PdlCQ9/Km+aZf3R5Kh2p0pSEmu1WXrrkWlKzE96EYjGBdYYTg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMtx6ETMAiWY2d2duJC3yWv5O1ln4BmblsfsY0RtBdhMYlHw1sbVoiLEGKZMKdBW2Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECYdyHpEuNGiqJd55P+ZO7BdKkSqxuddv3TordSoeyK39SMzSO1LQP5LW6CSIct1ww==");
        }
    }
}
