using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restoran.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 6, "Salads" },
                    { 7, "Soups" },
                    { 8, "Specials" }
                });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "Name",
                value: "Burger bun");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 7, "Cheese" },
                    { 8, "Onion" },
                    { 9, "Mayonnaise" },
                    { 10, "Spicy Sauce" },
                    { 11, "Coca-Cola" },
                    { 12, "Sprite" },
                    { 13, "Fanta" },
                    { 14, "Pepsi" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Tasty Beef Burger!", "/images/beefburger.png", "Beef Burger" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Tasty Chicken Burger!", "/images/chickenburger.png", "Chicken Burger" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Tasty Fish Burger!", "/images/fishburger.png", "Fish Burger" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { 4, 6, "Tasty Vegan Salad!", "/images/vegansalad.png", "Vegan Salad", 2.50m, 100 });

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 5, 4 },
                    { 6, 4 },
                    { 8, 4 },
                    { 10, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "Name",
                value: "Tortilla");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "beef taco", "https://via.placeholder.com/150", "Beef Taco" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "chicken taco", "https://via.placeholder.com/150", "Chicken Taco" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "fish taco", "https://via.placeholder.com/150", "Fish Taco" });
        }
    }
}
