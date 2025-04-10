using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CategoryId_Status",
                table: "Offers",
                columns: new[] { "CategoryId", "Status" });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_EndTime",
                table: "Offers",
                column: "EndTime");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_Status",
                table: "Offers",
                column: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
