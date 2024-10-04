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
    public class ProductsPutController : ProductsController
    {
        public ProductsPutController(IProductService productService) : base(productService)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductDTO>> UpdateProduct(int id, [FromBody] ProductDTO productDto)
        {
            if (id != productDto.Id)
            {
                return BadRequest(new { message = "El ID del producto no coincide." });
            }

            var updatedProduct = await _productService.UpdateProductAsync(productDto);

            if (updatedProduct == null)
            {
                return NotFound(new { message = $"Producto con ID {id} no encontrado." });
            }

            return Ok(updatedProduct);
        }
    }
}