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
    public class BlogDetailController : Controller
    {

        private readonly AppDbContext _context;

        public BlogDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Blog> blogs = await _context.Blogs.ToListAsync();
            Widget widget = await _context.Widgets.FirstOrDefaultAsync();
            IEnumerable<Social> socials = await _context.Socials.ToListAsync();
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();
            IEnumerable<Tag> tags = await _context.Tags.ToListAsync();


            BlogDetailVM blogVM = new BlogDetailVM
            {
                Widget = widget,
                Socials = socials,
                Categories = categories,
                Tags = tags,
                Blogs = blogs
            };

            return View(blogVM);
        }
    }
}
