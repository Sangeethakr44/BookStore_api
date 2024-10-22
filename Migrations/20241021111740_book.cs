using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class book : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8d9a4af-28ab-4170-b6e8-1b864141d2b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f759d0d9-1579-4921-9e77-7f120ea3820f");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "MasterBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "MasterBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MasterBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a011930b-f3ce-4ea0-87a6-b88cd3c432ad", null, "customer", "customer" },
                    { "c1f2eee2-cf44-4afa-8c5e-d8e4f0b6582d", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a011930b-f3ce-4ea0-87a6-b88cd3c432ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1f2eee2-cf44-4afa-8c5e-d8e4f0b6582d");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "MasterBooks");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "MasterBooks");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MasterBooks");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e8d9a4af-28ab-4170-b6e8-1b864141d2b6", null, "admin", "admin" },
                    { "f759d0d9-1579-4921-9e77-7f120ea3820f", null, "customer", "customer" }
                });
        }
    }
}
