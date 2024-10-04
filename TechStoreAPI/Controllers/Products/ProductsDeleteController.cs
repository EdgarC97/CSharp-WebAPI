using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechStoreAPI.DTOS;
using TechStoreAPI.Interfaces;

namespace TechStoreAPI.Controllers.Products
{
    [ApiController]
    [Route("api/v1/products")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class ProductsDeleteController : ProductsController
    {
        public ProductsDeleteController(IProductService productService) : base(productService)
        {
        }

        // DELETE: api/v1/products/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var result = await _productService.DeleteProductAsync(id);

            if (!result)
            {
                return NotFound(new { message = $"Product with ID {id} not found." });
            }

            return Ok(new { message = $"Product with ID {id} eliminado exitosamente." });
        }
    }
}