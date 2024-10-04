using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreAPI.Data;
using TechStoreAPI.DTOS;
using TechStoreAPI.Interfaces;
using TechStoreAPI.Models;

namespace TechStoreAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context;

        public OrderService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<OrderDTO> CreateOrderAsync(OrderDTO orderDto)
        {
            // Crear la nueva orden
            var order = new Order
            {
                State = orderDto.State,
                CreatedAt = DateTime.UtcNow,
                ClientId = orderDto.ClientId
            };

            // Agregar la orden al contexto
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync(); // Guarda para obtener el ID de la orden

            // Agregar los productos a la orden
            foreach (var orderProductDto in orderDto.OrderProducts)
            {
                var orderProduct = new OrderProduct
                {
                    OrderId = order.Id, // Asocia el ID de la orden
                    ProductId = orderProductDto.ProductId,
                    Quantity = orderProductDto.Quantity,
                    // Aquí puedes obtener el precio del producto si es necesario
                    Price = (await _context.Products.FindAsync(orderProductDto.ProductId)).Price
                };

                // Agregar el OrderProduct al contexto
                await _context.OrderProducts.AddAsync(orderProduct);
            }

            // Guardar los cambios para los productos de la orden
            await _context.SaveChangesAsync();

            // Asignar el ID de la orden al DTO
            orderDto.Id = order.Id;

            return orderDto; // Retornar el DTO actualizado
        }
    }
}