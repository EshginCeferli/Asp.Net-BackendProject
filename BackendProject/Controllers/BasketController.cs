using BackendProject.Data;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        public BasketController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            if ((Request.Cookies["basket"]) == null)
            {
                return RedirectToAction("Index","Home");
            }
            List<BasketVM> basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            List<BasketDetailVM> basketDetail = new List<BasketDetailVM>();


            int count = 0;
            
            if (basketItems != null)
            {
                foreach (var item in basketItems)
                {
                    Product product = await _context.Products
                        .Where(m => m.Id == item.Id && m.IsDeleted == false)
                        .Include(m => m.ProductImages).FirstOrDefaultAsync();

                    BasketDetailVM newBasket = new BasketDetailVM
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Image = product.ProductImages.Where(m => m.IsMain).FirstOrDefault().Image,
                        Price = product.Price,
                        Count = item.Count,
                        Total = product.Price * item.Count,                     
                        
                    };
                    count += item.Count;

                                       
                    basketDetail.Add(newBasket);
                }
                ViewData["Count"] = count;
                return View(basketDetail);                               
            }
            
           
            return View(basketDetail);


        }

        public  IActionResult RemoveProduct(int? id)
        {
            List<BasketVM> basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);

            var delProduct = basketItems.FirstOrDefault(m => m.Id == id);
            basketItems.Remove(delProduct);

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketItems));
            return RedirectToAction("Index", "Basket");           
        }
    }
}
