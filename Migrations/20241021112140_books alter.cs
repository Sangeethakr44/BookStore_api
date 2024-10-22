using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class booksalter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a011930b-f3ce-4ea0-87a6-b88cd3c432ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1f2eee2-cf44-4afa-8c5e-d8e4f0b6582d");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "MasterBooks",
                newName: "Categories");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "067df7cd-0a9c-4908-bf97-aee7f3a16f06", null, "customer", "customer" },
                    { "0fccbf2c-4c85-4ff8-8d1a-926435e3e173", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "067df7cd-0a9c-4908-bf97-aee7f3a16f06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fccbf2c-4c85-4ff8-8d1a-926435e3e173");

            migrationBuilder.RenameColumn(
                name: "Categories",
                table: "MasterBooks",
                newName: "Category");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a011930b-f3ce-4ea0-87a6-b88cd3c432ad", null, "customer", "customer" },
                    { "c1f2eee2-cf44-4afa-8c5e-d8e4f0b6582d", null, "admin", "admin" }
                });
        }
    }
}
