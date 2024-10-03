using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Models;

namespace TechStoreAPI.Seeders
{
    public class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Initialize the seed
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Smartphones", Description = "Dispositivos móviles avanzados con capacidades de computación." },
                new Category { Id = 2, Name = "Laptops", Description = "Computadoras portátiles para trabajo y entretenimiento." },
                new Category { Id = 3, Name = "Tablets", Description = "Dispositivos móviles con pantallas táctiles y portabilidad." },
                new Category { Id = 4, Name = "Accesorios", Description = "Complementos tecnológicos como auriculares, cargadores, y más." }
            );
        }
    }
}