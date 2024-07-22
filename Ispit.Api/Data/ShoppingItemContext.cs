using Ispit.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Ispit.Api.Data
{
    public class ShoppingItemContext : DbContext
    {
        public ShoppingItemContext(DbContextOptions<ShoppingItemContext> options) : base(options) { }
        public virtual DbSet<ShoppingItem> ShoppingItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ShoppingItem>()
               .Property(s => s.Price)
               .HasPrecision(18, 2);

            // Seed data for ShoppingItems
            modelBuilder.Entity<ShoppingItem>().HasData(
                new ShoppingItem { Id = 1, Name = "Laptop", Price = 999.99m, Manufacturer = "TechCorp" },
                new ShoppingItem { Id = 2, Name = "Smartphone", Price = 499.99m, Manufacturer = "Gizmo Inc." },
                new ShoppingItem { Id = 3, Name = "Headphones", Price = 89.99m, Manufacturer = "AudioPro" },
                new ShoppingItem { Id = 4, Name = "Keyboard", Price = 29.99m, Manufacturer = "KeyMaster" },
                new ShoppingItem { Id = 5, Name = "Mouse", Price = 19.99m, Manufacturer = "Clicker" },
                new ShoppingItem { Id = 6, Name = "Monitor", Price = 149.99m, Manufacturer = "VisionTech" },
                new ShoppingItem { Id = 7, Name = "Printer", Price = 79.99m, Manufacturer = "PrintMaster" },
                new ShoppingItem { Id = 8, Name = "Webcam", Price = 59.99m, Manufacturer = "CamCo" },
                new ShoppingItem { Id = 9, Name = "USB Drive", Price = 12.99m, Manufacturer = "DataStick" },
                new ShoppingItem { Id = 10, Name = "External Hard Drive", Price = 129.99m, Manufacturer = "StoragePlus" }
            );
        }
    }
}
