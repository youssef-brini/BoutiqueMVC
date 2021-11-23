using Boutique.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Controllers
{
    public class EmployesController : Controller
    {
        private readonly BoutiqueDbContext _context;
        public EmployesController(BoutiqueDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var allEmployes = await _context.Employes.ToListAsync();
            return View();
        }
    }
}
