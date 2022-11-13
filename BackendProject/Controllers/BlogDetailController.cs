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
        public async Task<IActionResult> Index(int? id)
        {
            if (id is null) return BadRequest();

            Blog blog = await _context.Blogs.Include(m => m.Comments)
                .FirstOrDefaultAsync(m => m.Id == id);
                

            if (blog is null) return NotFound();
            
            Widget widget = await _context.Widgets.FirstOrDefaultAsync();
            IEnumerable<Social> socials = await _context.Socials.ToListAsync();
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();
            IEnumerable<Tag> tags = await _context.Tags.ToListAsync();
            IEnumerable<Comment> comments = await _context.Comments.ToListAsync();

            List<RecentBlog> recentBlogs = new List<RecentBlog>();

            List<Blog> blogs = await _context.Blogs.ToListAsync();
            foreach (var item in blogs)
            {
                RecentBlog recentBlog = new RecentBlog
                {
                    Id = item.Id,
                    IsDeleted = item.IsDeleted,
                    Image = item.Image,
                    Title = item.Title,
                    By = item.By,
                    Date = item.Date
                    
                    
                };
                recentBlogs.Add(recentBlog);
            }           
           

            BlogDetailVM blogVM = new BlogDetailVM
            {
                Widget = widget,
                Socials = socials,
                Categories = categories,
                Tags = tags,
                Blog = blog,
                RecentBlogs = recentBlogs,
                Comments = comments
            };

            return View(blogVM);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Comment(Comment newComment)
        {
            if (!ModelState.IsValid) return BadRequest();

            Comment comment = new Comment()
            {
                Content = newComment.Content,
                BlogId = newComment.BlogId,
                //UserName = User.Identity.Name.ToString(),
                Datetime = DateTime.Now.ToString()                               
            };

            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { id = comment.BlogId });
        }
    }
}
