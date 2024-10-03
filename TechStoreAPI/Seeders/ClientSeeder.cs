using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Models;

namespace TechStoreAPI.Seeders
{
    public class ClientSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Inicializa los datos de los clientes
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, Name = "Juan Pérez", Address = "Av. Siempre Viva 123, Ciudad", PhoneNumber = "123-456-7890", Email = "juan.perez@example.com" },
                new Client { Id = 2, Name = "María López", Address = "Calle Falsa 456, Ciudad", PhoneNumber = "234-567-8901", Email = "maria.lopez@example.com" },
                new Client { Id = 3, Name = "Carlos García", Address = "Paseo de la Reforma 789, Ciudad", PhoneNumber = "345-678-9012", Email = "carlos.garcia@example.com" },
                new Client { Id = 4, Name = "Ana Martínez", Address = "Calle del Sol 101, Ciudad", PhoneNumber = "456-789-0123", Email = "ana.martinez@example.com" }
            );
        }
    }
}