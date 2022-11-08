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

            Product product = await _context.Products.Include(m => m.ProductImages).FirstOrDefaultAsync(m => m.Id == id);
            List<Product> products = await _context.Products.Take(5).Include(m=>m.ProductImages)?.ToListAsync();
            RelatedHeader relatedHeader = await _context.RelatedHeaders.FirstOrDefaultAsync();
            List<Social> social = await _context.Socials.ToListAsync();

                        
            if (product is null) return NotFound();

            ProductDetailVM productDetailVM = new ProductDetailVM()
            {
                Product = product,
                Products = products,
                Socials = social,
                RelatedHeader = relatedHeader
                
            };

            return View(productDetailVM);
        }
    }
}
