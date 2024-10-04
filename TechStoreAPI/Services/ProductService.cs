using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Data;
using TechStoreAPI.DTOS;
using TechStoreAPI.Interfaces;
using TechStoreAPI.Models;

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
                Quantity = p.Quantity,
                CategoryId = p.CategoryId

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
                Quantity = product.Quantity,
                CategoryId = product.CategoryId

            };
        }

        // Método para crear un producto
        public async Task<ProductDTO> CreateProductAsync(ProductDTO productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price,
                Quantity = productDto.Quantity,
                CategoryId = productDto.CategoryId
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Quantity = product.Quantity,
                CategoryId = product.CategoryId
            };
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return false; // Product not found
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true; // Product deleted successfully
        }

        //Update Product
        public async Task<ProductDTO> UpdateProductAsync(ProductDTO productDto)
        {
            var existingProduct = await _context.Products.FindAsync(productDto.Id);
            if (existingProduct == null)
            {
                return null; // Producto no encontrado
            }

            // Actualizar las propiedades del producto existente
            existingProduct.Name = productDto.Name;
            existingProduct.Description = productDto.Description;
            existingProduct.Price = productDto.Price;
            existingProduct.Quantity = productDto.Quantity;
            existingProduct.CategoryId = productDto.CategoryId;

            await _context.SaveChangesAsync();

            return productDto; // Devolver el DTO actualizado
        }


    }
}