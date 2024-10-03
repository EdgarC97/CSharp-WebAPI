using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Models;

namespace TechStoreAPI.Seeders
{
    public class ProductSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Inicializa los datos de los productos
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "iPhone 13", Description = "Smartphone de Apple con pantalla de 6.1 pulgadas.", Price = 799.99m, Quantity = 50, CategoryId = 1 },
                new Product { Id = 2, Name = "Samsung Galaxy S21", Description = "Smartphone de Samsung con tecnología de cámara avanzada.", Price = 699.99m, Quantity = 30, CategoryId = 1 },
                new Product { Id = 3, Name = "Dell XPS 13", Description = "Laptop compacta y poderosa con pantalla InfinityEdge.", Price = 999.99m, Quantity = 20, CategoryId = 2 },
                new Product { Id = 4, Name = "iPad Pro", Description = "Tablet de Apple con chip M1 y pantalla Liquid Retina.", Price = 1099.99m, Quantity = 25, CategoryId = 3 },
                new Product { Id = 5, Name = "Logitech MX Master 3", Description = "Ratón ergonómico avanzado para productividad.", Price = 99.99m, Quantity = 100, CategoryId = 4 }
            );
        }
    }
}