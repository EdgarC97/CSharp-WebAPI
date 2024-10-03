using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Data;
using TechStoreAPI.DTOS;
using TechStoreAPI.Interfaces;

namespace TechStoreAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        // Método para obtener todos los productos
        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            var products = await _context.Products
                .ToListAsync();

            // Mapear a ProductDTO
            var productDTOs = products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Quantity = p.Quantity
            });

            return productDTOs;
        }

        // Método para obtener un producto por ID
        public async Task<ProductDTO> GetProductsByIdAsync(int id)
        {
            var product = await _context.Products
                .FindAsync(id);

            if (product == null) return null;

            // Mapear a ProductDTO
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }
    }
}