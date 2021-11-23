using Boutique.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Controllers
{
    public class FournisseursController : Controller
    {
        private readonly BoutiqueDbContext _context;
        public FournisseursController(BoutiqueDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allFournisseurs = await _context.Fournisseurs.ToListAsync();
            return View();
        }
    }
}
