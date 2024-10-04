using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Models;
using TechStoreAPI.Seeders;

namespace TechStoreAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data for various entities
            RoleSeeder.Seed(modelBuilder); // Seed roles
            CategorySeeder.Seed(modelBuilder); // Seed categories
            ProductSeeder.Seed(modelBuilder); // Seed products
            ClientSeeder.Seed(modelBuilder); // Seed clients
            OrderSeeder.Seed(modelBuilder); // Seed orders
            UserSeeder.Seed(modelBuilder); // Seed users
            OrderProductSeeder.Seed(modelBuilder); // Seed order products

            // Configure the many-to-many relationship for OrderProducts
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => op.Id); // Composite primary key

            modelBuilder.Entity<OrderProduct>()
                .HasOne(css => css.Order) // Relationship to Order
                .WithMany(c => c.OrderProducts)
                .HasForeignKey(css => css.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete

            modelBuilder.Entity<OrderProduct>()
                .HasOne(css => css.Product) // Relationship to Product
                .WithMany(ss => ss.OrderProducts)
                .HasForeignKey(css => css.ProductId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete

        }
    }
}