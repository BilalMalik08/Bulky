using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCategoryAndProductTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 4, 4, "Science Fiction" },
                    { 5, 5, "Thriller" },
                    { 6, 6, "Romance" },
                    { 7, 7, "Fantasy" },
                    { 8, 8, "Adventure" },
                    { 9, 9, "Nature" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 4, "Explore the delicate dance between destiny and choice in this gripping tale of time travel and its profound effects on the lives it touches. A journey through the ages where every decision alters the future.", 999.0, 900.0, 800.0, 850.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 5, "A haunting narrative of survival and hope in a world overshadowed by chaos. Follow the characters as they navigate through ominous landscapes and uncover secrets that could change everything.", 400.0, 300.0, 200.0, 250.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 6, "A heartwarming story of love, loss, and self-discovery, set against the backdrop of breathtaking sunsets. A tale that will make you believe in the power of new beginnings.", 550.0, 500.0, 350.0, 400.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 7, "Dive into a sweet and whimsical world where dreams are spun into reality. This enchanting tale captures the innocence of childhood and the joy of seeing magic in everyday life.", 700.0, 650.0, 550.0, 600.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 8, "An inspiring story of resilience and strength, set on the rugged shores where land meets sea. This novel explores the timeless battle between the elements and the human spirit.", 300.0, 270.0, 200.0, 250.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 9, "Step into a world of natural beauty and hidden mysteries. This lyrical narrative weaves together tales of wonder and wisdom, all inspired by the simple, yet profound, beauty of nature.", 250.0, 230.0, 200.0, 220.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 1, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", 99.0, 90.0, 80.0, 85.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 1, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", 40.0, 30.0, 20.0, 25.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 2, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", 55.0, 50.0, 35.0, 40.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 2, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", 70.0, 65.0, 55.0, 60.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 3, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", 30.0, 27.0, 20.0, 25.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 3, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", 25.0, 23.0, 20.0, 22.0 });
        }
    }
}
