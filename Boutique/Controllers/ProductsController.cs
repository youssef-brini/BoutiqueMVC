using Boutique.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Controllers
{
    public class ProductsController : Controller
    {
        private readonly BoutiqueDbContext _context;
        public ProductsController(BoutiqueDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var allProducts = await _context.Products.ToListAsync();
            return View(allProducts);
        }
    }
}
