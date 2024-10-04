using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStoreAPI.DTOS;
using TechStoreAPI.Interfaces;

namespace TechStoreAPI.Controllers.Products
{
    [ApiController]
    [Route("api/v1/products")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class ProductsPostController : ProductsController
    {
        public ProductsPostController(IProductService productService) : base(productService)
        {
        }

        // POST: api/v1/products
        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateProduct([FromBody] ProductDTO productDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdProduct = await _productService.CreateProductAsync(productDTO);
            return CreatedAtAction(nameof(CreateProduct), new { id = createdProduct.Id }, createdProduct);
        }
    }
}