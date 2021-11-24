using Boutique.Models;
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
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            var results = _context.Products.ToList();
            return results;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
