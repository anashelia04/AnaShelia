using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("1a192769-0f4a-4e23-b1fc-69ce57f259d7"));

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("d14170ce-2ef3-483a-a6e0-05d9c326ab93"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f00ecee-932a-45a7-ba22-657722fe6cbc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea6b4806-51e4-4e30-91e5-19c2d8e8b1f3"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("63ea8a32-c5c6-4382-a39f-d1fa8fa27f64"), "Groceries, Meals", "Food" },
                    { new Guid("a6f12969-0e5e-4715-9fd2-c23b74f3f5d4"), "Drinks", "Beverages" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CategoryId", "Description", "EndTime", "ImageUrl", "Quantity", "StartTime", "Status", "Title", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("af19dff2-6691-4fef-9650-4cabcbbefb6e"), new Guid("63ea8a32-c5c6-4382-a39f-d1fa8fa27f64"), "Get half price on all freshly baked bread", new DateTime(2025, 4, 16, 17, 49, 40, 276, DateTimeKind.Local).AddTicks(311), null, 20, new DateTime(2025, 4, 9, 17, 49, 40, 276, DateTimeKind.Local).AddTicks(299), 0, "Bread", 2.50m },
                    { new Guid("d7d9d2db-4f4b-4e8b-9055-37a8549dc299"), new Guid("a6f12969-0e5e-4715-9fd2-c23b74f3f5d4"), "Purchase any coffee and get another one free", new DateTime(2025, 4, 23, 17, 49, 40, 276, DateTimeKind.Local).AddTicks(320), null, 50, new DateTime(2025, 4, 9, 17, 49, 40, 276, DateTimeKind.Local).AddTicks(319), 0, "Coffee", 3.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("af19dff2-6691-4fef-9650-4cabcbbefb6e"));

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("d7d9d2db-4f4b-4e8b-9055-37a8549dc299"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63ea8a32-c5c6-4382-a39f-d1fa8fa27f64"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6f12969-0e5e-4715-9fd2-c23b74f3f5d4"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("8f00ecee-932a-45a7-ba22-657722fe6cbc"), "Groceries, Meals", "Food" },
                    { new Guid("ea6b4806-51e4-4e30-91e5-19c2d8e8b1f3"), "Drinks", "Beverages" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CategoryId", "Description", "EndTime", "ImageUrl", "Quantity", "StartTime", "Status", "Title", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("1a192769-0f4a-4e23-b1fc-69ce57f259d7"), new Guid("ea6b4806-51e4-4e30-91e5-19c2d8e8b1f3"), "Purchase any coffee and get another one free", new DateTime(2025, 4, 23, 16, 18, 42, 690, DateTimeKind.Local).AddTicks(4610), null, 50, new DateTime(2025, 4, 9, 16, 18, 42, 690, DateTimeKind.Local).AddTicks(4610), 0, "Coffee", 3.99m },
                    { new Guid("d14170ce-2ef3-483a-a6e0-05d9c326ab93"), new Guid("8f00ecee-932a-45a7-ba22-657722fe6cbc"), "Get half price on all freshly baked bread", new DateTime(2025, 4, 16, 16, 18, 42, 690, DateTimeKind.Local).AddTicks(4600), null, 20, new DateTime(2025, 4, 9, 16, 18, 42, 690, DateTimeKind.Local).AddTicks(4560), 0, "Bread", 2.50m }
                });
        }
    }
}
