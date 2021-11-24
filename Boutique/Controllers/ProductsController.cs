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
        public  IActionResult Index()
        {
            var allProducts =  _service.GetAll();
            return View(allProducts);
        }
        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("ProductImg,Name,ProductType,ProductPrice,QuantiteDispo")] Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            _service.Add(product);
            return RedirectToAction(nameof(Index));
        }

    }
}
