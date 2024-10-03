using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Models;

namespace TechStoreAPI.Seeders
{
    public class OrderProductSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Inicializa los datos de OrderProduct
            modelBuilder.Entity<OrderProduct>().HasData(
                new OrderProduct { Id = 1, OrderId = 1, ProductId = 1, Quantity = 2, Price = 699.99m }, // Ejemplo: 2 smartphones
                new OrderProduct { Id = 2, OrderId = 1, ProductId = 3, Quantity = 1, Price = 299.99m }, // Ejemplo: 1 tablet
                new OrderProduct { Id = 3, OrderId = 2, ProductId = 2, Quantity = 1, Price = 999.99m }, // Ejemplo: 1 laptop
                new OrderProduct { Id = 4, OrderId = 3, ProductId = 4, Quantity = 3, Price = 49.99m }   // Ejemplo: 3 accesorios
            );
        }
    }
}