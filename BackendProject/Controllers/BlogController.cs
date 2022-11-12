using BackendProject.Data;
using BackendProject.Helpers;
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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page = 1, int take = 6)
        {
            IEnumerable<Blog> blogs = await _context.Blogs
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();
            Widget widget = await _context.Widgets.FirstOrDefaultAsync();
            IEnumerable<Social> socials = await _context.Socials.ToListAsync();
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();
            IEnumerable<Tag> tags = await _context.Tags.ToListAsync();

            ViewBag.take = take;

            List<BlogVM> blogVMs = new List<BlogVM>
            {
                new BlogVM
                {
                    Blogs = blogs,
                    Categories = categories,
                    Socials = socials,
                    Tags = tags,
                    Widget = widget
                }
            };
            var mapDatas = blogVMs;

            int count = await GetPageCount(take);

            Paginate<BlogVM> result = new Paginate<BlogVM>(mapDatas, page, count);

            return View(result);
        }

        

        private async Task<int> GetPageCount(int take)
        {
            int blogCount = await _context.Blogs.CountAsync();

            return (int)Math.Ceiling((decimal)blogCount / take);
        }

       
    }
}
