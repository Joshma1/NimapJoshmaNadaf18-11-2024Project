using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Nimap.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //////////////////////////////////
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adding categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Electronics" },
                new Category { CategoryId = 2, CategoryName = "Books" },
                new Category { CategoryId = 3, CategoryName = "Clothing" }
            );

            // Adding 100 products
            var products = new List<Product>();
            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    ProductId = i,
                    ProductName = $"Product {i}",
                    CategoryId = (i % 3) + 1 // Assign to a category in a cyclic manner
                });
            }

            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}