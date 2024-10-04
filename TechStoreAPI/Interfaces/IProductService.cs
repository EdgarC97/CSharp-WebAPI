using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreAPI.DTOS;
using TechStoreAPI.Models;

namespace TechStoreAPI.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetProductsByIdAsync(int id);
        Task<ProductDTO> CreateProductAsync(ProductDTO productDTO);
        Task<ProductDTO> UpdateProductAsync(ProductDTO productDto);
        Task<bool> DeleteProductAsync(int id);
        
    }
}