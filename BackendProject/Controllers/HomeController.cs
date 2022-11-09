
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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


        //[HttpPost]
        //[AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id is null) return BadRequest();

            var dbProduct = await GetProductById(id);

            if (dbProduct == null) return NotFound();

            List<BasketVM> basket = GetBasket();       

            UpdateBasket(basket, dbProduct.Id);

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
          


            return RedirectToAction("Index");
        }


        private void UpdateBasket(List<BasketVM> basket, int id)
        {
            BasketVM existProduct = basket.FirstOrDefault(m => m.Id == id);

            if (existProduct == null)
            {
                basket.Add(new BasketVM
                {
                    Id = id,
                    Count = 1
                });
            }
            else
            {
                existProduct.Count++;
            }
        }

        private async Task<Product> GetProductById(int? id)
        {
            return await _context.Products.FindAsync(id);
        }

        private List<BasketVM> GetBasket()
        {
            List<BasketVM> basket;

            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }

            return basket;
        }

    }
}
