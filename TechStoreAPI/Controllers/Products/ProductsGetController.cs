using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechStoreAPI.Data;
using TechStoreAPI.DTOS;
using TechStoreAPI.Interfaces;
using TechStoreAPI.Services;

namespace TechStoreAPI.Controllers.Products
{
    [ApiController]
    [Route("api/v1/products")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class ProductsGetController : ProductsController
    {
        public ProductsGetController(IProductService productService) : base(productService)
        {
        }

        // GET: api/v1/products
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            var products = await _productService.GetProductsAsync();
            if (products == null || !products.Any())
            {
                return NotFound(new { message = "No products found. Please check back later!" });
            }
            return Ok(new
            {
                message = "Products retrieved successfully.",
                data = products
            });
        }

        // GET: api/v1/products/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProductById(int id)
        {
            var product = await _productService.GetProductsByIdAsync(id);

            if (product == null)
            {
                return NotFound(new { message = $"Product with ID {id} not found." });
            }

            return Ok(new
            {
                message = "Product retrieved successfully.",
                data = product
            });
        }

    }
}