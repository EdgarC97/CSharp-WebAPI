using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_1.Models
{
    [Table("players")]
    public class Player
    {
        [Key]
        public int Id { get; set; }         // ID del jugador
        public string? Name { get; set; }    // Nombre del jugador
        public string? Position { get; set; } // Posición del jugador (delantero, mediocampista, etc.)
        public int Age { get; set; }        // Edad del jugador
        public decimal Salary { get; set; } // Salario del jugador
        public string? ImageUrl { get; set; } //Imagen del jugador
    }
}