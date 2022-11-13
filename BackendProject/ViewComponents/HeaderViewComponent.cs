using BackendProject.Data;
using BackendProject.Models;
using BackendProject.Services;
using BackendProject.ViewModels;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly LayoutService _layoutService;
        private readonly AppDbContext _context;
       
        public HeaderViewComponent(LayoutService layoutService, AppDbContext context)
        {
            _layoutService = layoutService;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int count = 0;
            List<BasketDetailVM> basketDetailVMs = new List<BasketDetailVM>();
            if (Request.Cookies["basket"] != null)
            {
                List<BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
                                
                //List<BasketDetailVM> basketDetail = new List<BasketDetailVM>();

               
                foreach (var item in basket)
                {
                    Product product = await _context.Products
                        .Where(m => m.Id == item.Id )
                        .Include(m => m.ProductImages)
                        .Include(m=>m.Category)
                        .FirstOrDefaultAsync()
                        ;

                    BasketDetailVM newBasket = new BasketDetailVM
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Image = product.ProductImages.Where(m => m.IsMain).FirstOrDefault().Image,
                        Price = product.Price,
                        Count = item.Count,
                        CategoryId = product.CategoryId,
                        Total = product.Price * item.Count,
                       
                    };                  

                    basketDetailVMs.Add(newBasket);
                }
                //count = basket.Count();

                //foreach (var item in basket)
                //{
                //    count += item.Count;
                //}

                count = basket.Sum(m => m.Count);

            }
            else
            {
                count = 0;
            }           
            
            Dictionary<string, string> datas = await _layoutService.GetDatasFromSetting();

            HeaderVM headerVM = new HeaderVM
            {
                Count = count,
                Settings = datas,     
                BasketDetails = basketDetailVMs,
            };


            return await Task.FromResult(View(headerVM));
        }

    }
}
