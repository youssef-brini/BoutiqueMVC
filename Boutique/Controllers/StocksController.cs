using Boutique.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Controllers
{
    public class StocksController : Controller
    {
        private readonly BoutiqueDbContext _context;
        public StocksController(BoutiqueDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allStocks = await _context.Stocks.ToListAsync();
            return View();
        }
    }
}
