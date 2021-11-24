using Boutique.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Controllers
{
    public class CommandesController : Controller
    {
        private readonly BoutiqueDbContext _context;
        public CommandesController(BoutiqueDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCommandes = await _context.Commandes.ToListAsync();
            return View(allCommandes);
        }
    }
}
