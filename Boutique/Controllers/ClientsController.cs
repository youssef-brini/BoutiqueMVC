using Boutique.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Controllers
{
    public class ClientsController : Controller
    {
        private readonly BoutiqueDbContext _context;
        public ClientsController(BoutiqueDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allClients = await _context.Clients.ToListAsync();
            return View();
        }
    }
}
