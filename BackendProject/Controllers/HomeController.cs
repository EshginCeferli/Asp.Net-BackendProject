
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();
            IEnumerable<Link> links = await _context.Links.ToListAsync();
            IEnumerable<Product> products = await _context.Products
                .Include(m=>m.ProductImages)                 
                .ToListAsync();
            ProductHeader productHeader = await _context.ProductHeaders.FirstOrDefaultAsync();
            IEnumerable<Banner> banners = await _context.Banners.ToListAsync();
            IEnumerable<Blog> blogs = await _context.Blogs.ToListAsync();
            BlogHeader blogHeader = await _context.BlogHeaders.FirstOrDefaultAsync();
            IEnumerable<Brand> brands = await _context.Brands.ToListAsync();
            TopHeader topHeader = await _context.TopHeaders.FirstOrDefaultAsync();

            HomeVM homeVM = new HomeVM
            {                             
                Sliders = sliders,
                Links = links,
                Products= products,
                ProductHeader = productHeader,
                Banners = banners,
                Blogs = blogs,
                BlogHeader = blogHeader,
                Brands = brands,
                TopHeader = topHeader
                
            };
            return View(homeVM);
        }     

    }
}
