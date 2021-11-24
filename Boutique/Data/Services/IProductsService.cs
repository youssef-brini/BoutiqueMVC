using Boutique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Data.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        Product Update(int id, Product product);
        void Delete(int id);
    }
}
