using Boutique.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Controllers
{
    public class VentesController : Controller
    {
        private readonly BoutiqueDbContext _context;
        public VentesController(BoutiqueDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allVentes= await _context.Ventes.ToListAsync();
            return View();
        }
    }
}
