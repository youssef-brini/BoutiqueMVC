using Boutique.Data;
using Boutique.Data.Services;
using Boutique.Models;
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
        private readonly IProductsService _service;
        public ProductsController(IProductsService service)
        {
            _service = service;

        }
        public  async Task<IActionResult> Index()
        {
            var allProducts =  await _service.GetAllAsync();
            return View(allProducts);
        }
        public async Task<IActionResult> Details(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
                if (productDetails == null)
                return View("Empty");
            return View(productDetails);
        }
        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProductImg,Name,ProductType,ProductPrice,QuantiteDispo")] Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            await _service.AddAsync(product);
            return RedirectToAction(nameof(Index));
        }

    }
}
