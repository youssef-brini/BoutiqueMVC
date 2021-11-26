using Boutique.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Data.Services
{
    public class ProductsService : IProductsService
    {
        private readonly BoutiqueDbContext _context;
        public ProductsService(BoutiqueDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var results = await _context.Products.ToListAsync();
            return results;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var result = await _context.Products.FirstOrDefaultAsync(n => n.ProductId == id);
            return result;
        }

        public Product Update(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
