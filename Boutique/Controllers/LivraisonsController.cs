using Boutique.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Controllers
{
    public class LivraisonsController : Controller
    {
        private readonly BoutiqueDbContext _context;
        public LivraisonsController(BoutiqueDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allLivraison = await _context.Livraisons.ToListAsync();
            return View();
        }
    }
}
