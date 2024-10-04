using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStoreAPI.DTOS;
using TechStoreAPI.Interfaces;

namespace TechStoreAPI.Controllers.Orders
{
    [ApiController]
    [Route("api/v1/orders")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class OrdersPostController : OrdersController
    {
        public OrdersPostController(IOrderService orderService) : base(orderService)
        {
        }

        // POST: api/v1/orders
        [HttpPost]
        public async Task<ActionResult<OrderDTO>> CreateOrder([FromBody] OrderDTO orderDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdOrder = await _orderService.CreateOrderAsync(orderDTO);
            return CreatedAtAction(nameof(CreateOrder), new { id = createdOrder.Id }, createdOrder);
        }
    }
}