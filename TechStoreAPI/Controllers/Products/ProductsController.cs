using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStoreAPI.Interfaces;

namespace TechStoreAPI.Controllers.Products
{

    public class ProductsController : ControllerBase
    {
        protected readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
    }
}