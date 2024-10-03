using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreAPI.DTOS;

namespace TechStoreAPI.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetProductsByIdAsync(int id);
    }
}