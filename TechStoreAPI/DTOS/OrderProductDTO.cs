using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreAPI.DTOS
{
    public class OrderProductDTO
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}