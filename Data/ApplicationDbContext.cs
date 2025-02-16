using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Restoran.Models;

namespace Restoran.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<ProductIngredient> ProductIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define composite key and relationships for ProductIngredient
            modelBuilder.Entity<ProductIngredient>()
                .HasKey(pi => new { pi.ProductId, pi.IngredientId });

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductIngredients)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(i => i.ProductIngredients)
                .HasForeignKey(pi => pi.IngredientId);

            //Seed Data
            modelBuilder.Entity<Category>().HasData(
               new Category { CategoryId = 1, Name = "Appetizer" },
               new Category { CategoryId = 2, Name = "Entree" },
               new Category { CategoryId = 3, Name = "Side Dish" },
               new Category { CategoryId = 4, Name = "Dessert" },
               new Category { CategoryId = 5, Name = "Beverage" },
               new Category { CategoryId = 6, Name = "Salads" },
               new Category { CategoryId = 7, Name = "Soups" },
               new Category { CategoryId = 8, Name = "Specials" }
           );

            modelBuilder.Entity<Ingredient>().HasData(

              new Ingredient { IngredientId = 1, Name = "Beef" },
              new Ingredient { IngredientId = 2, Name = "Chicken" },
              new Ingredient { IngredientId = 3, Name = "Fish" },
              new Ingredient { IngredientId = 4, Name = "Burger bun" },
              new Ingredient { IngredientId = 5, Name = "Lettuce" },
              new Ingredient { IngredientId = 6, Name = "Tomato" },
              new Ingredient { IngredientId = 7, Name = "Cheese" },
              new Ingredient { IngredientId = 8, Name = "Onion" },
              new Ingredient { IngredientId = 9, Name = "Mayonnaise" },
              new Ingredient { IngredientId = 10, Name = "Spicy Sauce" },
              new Ingredient { IngredientId = 11, Name = "Coca-Cola" },
              new Ingredient { IngredientId = 12, Name = "Sprite" },
              new Ingredient { IngredientId = 13, Name = "Fanta" },
              new Ingredient { IngredientId = 14, Name = "Pepsi" }
          );

            modelBuilder.Entity<Product>().HasData(


                new Product
                {
                    ProductId = 1,
                    Name = "Beef Burger",
                    Description = "Tasty Beef Burger!",
                    Price = 2.50m,
                    Stock = 100,
                    CategoryId = 2,
                    ImageUrl = "/images/beefburger.png"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Chicken Burger",
                    Description = "Tasty Chicken Burger!",
                    Price = 1.99m,
                    Stock = 101,
                    CategoryId = 2,
                    ImageUrl = "/images/chickenburger.png"
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Fish Burger",
                    Description = "Tasty Fish Burger!",
                    Price = 3.99m,
                    Stock = 90,
                    CategoryId = 2,
                    ImageUrl = "/images/fishburger.png"
                },
                 new Product
                 {
                     ProductId = 4,
                     Name = "Vegan Salad",
                     Description = "Tasty Vegan Salad!",
                     Price = 2.50m,
                     Stock = 100,
                     CategoryId = 6,
                     ImageUrl = "/images/vegansalad.png"
                 },
                 new Product
                 {
                     ProductId = 5,
                     Name = "Coca-Cola",
                     Description = "Refreshing Coca-Cola!",
                     Price = 2.50m,
                     Stock = 100,
                     CategoryId = 5,
                     ImageUrl = "/images/cola.png"
                 },
                 new Product
                 {
                     ProductId = 6,
                     Name = "Fanta",
                     Description = "Refreshing Fanta!",
                     Price = 2.50m,
                     Stock = 100,
                     CategoryId = 5,
                     ImageUrl = "/images/fanta.png"
                 }
                );

            modelBuilder.Entity<ProductIngredient>().HasData(
                new ProductIngredient { ProductId = 1, IngredientId = 1 },
                new ProductIngredient { ProductId = 1, IngredientId = 4 },
                new ProductIngredient { ProductId = 1, IngredientId = 5 },
                new ProductIngredient { ProductId = 1, IngredientId = 6 },
                new ProductIngredient { ProductId = 2, IngredientId = 2 },
                new ProductIngredient { ProductId = 2, IngredientId = 4 },
                new ProductIngredient { ProductId = 2, IngredientId = 5 },
                new ProductIngredient { ProductId = 2, IngredientId = 6 },
                new ProductIngredient { ProductId = 3, IngredientId = 3 },
                new ProductIngredient { ProductId = 3, IngredientId = 4 },
                new ProductIngredient { ProductId = 3, IngredientId = 5 },
                new ProductIngredient { ProductId = 3, IngredientId = 6 },
                new ProductIngredient { ProductId = 4, IngredientId = 5 },
                new ProductIngredient { ProductId = 4, IngredientId = 6 },
                new ProductIngredient { ProductId = 4, IngredientId = 8 },
                new ProductIngredient { ProductId = 4, IngredientId = 10 }
                );
        }
    }

}
