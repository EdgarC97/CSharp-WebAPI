using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreAPI.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}