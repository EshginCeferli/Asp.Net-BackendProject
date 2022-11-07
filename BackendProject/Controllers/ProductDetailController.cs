using BackendProject.Data;
using BackendProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Controllers
{
    public class ProductDetailController : Controller
    {

        private readonly AppDbContext _context;

        public ProductDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (id is null) return BadRequest();

            Product product = await _context.Products.FindAsync(id);

            if (product is null) return NotFound();

            return View();
        }
    }
}
