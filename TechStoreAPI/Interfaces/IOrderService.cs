using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreAPI.DTOS;

namespace TechStoreAPI.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDTO> CreateOrderAsync(OrderDTO orderDto);
    }
}