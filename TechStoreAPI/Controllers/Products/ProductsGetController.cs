using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStoreAPI.Data;
using TechStoreAPI.DTOS;
using TechStoreAPI.Interfaces;
using TechStoreAPI.Services;

namespace TechStoreAPI.Controllers.Products
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class ProductsGetController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsGetController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/v1/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            var products = await _productService.GetProductsAsync();
            return Ok(products);
        }

        // GET: api/v1/products/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProductById(int id)
        {
            var product = await _productService.GetProductsByIdAsync(id);

            if (product == null)
            {
                return NotFound(); // 404 Not Found
            }

            return Ok(product); // 200 OK
        }
    }
}