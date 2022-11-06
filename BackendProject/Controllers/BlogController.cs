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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Blog> blogs = await _context.Blogs.ToListAsync();
            Widget widget = await _context.Widgets.FirstOrDefaultAsync();
            IEnumerable<Social> socials = await _context.Socials.ToListAsync();
            BlogVM blogVM = new BlogVM {
                Blogs = blogs,
                Widget = widget,
                Socials =socials
            };

            return View(blogVM);
        }
    }
}
