using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreAPI.DTOS
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string State { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ClientId { get; set; }
        public List<OrderProductDTO> OrderProducts { get; set; } = new List<OrderProductDTO>();
    }
}