using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Models;

namespace TechStoreAPI.Seeders
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Inicializa los datos de los usuarios
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Admin User", Email = "admin@example.com", Password = "AdminPass123", RoleId = 1 }, // Rol: Admin
                new User { Id = 2, Name = "Regular User", Email = "user@example.com", Password = "UserPass123", RoleId = 2 } // Rol: User
                
            );
        }
    }
}