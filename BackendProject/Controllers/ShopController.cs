using BackendProject.Data;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Controllers
{
    public class ShopController : Controller
    {

        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _context.Products.Include(m => m.ProductImages).ToListAsync();
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();
            IEnumerable<Color> colors = await _context.Colors.ToListAsync();
            IEnumerable<Size> sizes = await _context.Sizes.ToListAsync();

            ShopVM shopVM = new ShopVM()
            {
                Products = products,
                Categories = categories,
                Colors = colors,
                Sizes = sizes
            };
            return View(shopVM);
        }
    }
}
