using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Models;

namespace TechStoreAPI.Seeders
{
    public class OrderSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Inicializa los datos de las órdenes
            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, State = "Pending", CreatedAt = DateTime.UtcNow, ClientId = 1 },
                new Order { Id = 2, State = "Shipped", CreatedAt = DateTime.UtcNow.AddDays(-1), ClientId = 2 },
                new Order { Id = 3, State = "Delivered", CreatedAt = DateTime.UtcNow.AddDays(-2), ClientId = 3 },
                new Order { Id = 4, State = "Pending", CreatedAt = DateTime.UtcNow.AddDays(-3), ClientId = 4 }
            );
        }
    }
}