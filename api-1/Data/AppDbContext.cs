using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_1.Models;
using Microsoft.EntityFrameworkCore;

namespace api_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura la entidad Player para mapear a la tabla "players"
            modelBuilder.Entity<Player>()
                .ToTable("players");
        }
    }
}