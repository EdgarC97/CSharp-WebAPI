using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStoreAPI.Interfaces;

namespace TechStoreAPI.Controllers.Orders
{
    [Route("orders")]
    public class OrdersController : ControllerBase
    {
        protected readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
    }
}