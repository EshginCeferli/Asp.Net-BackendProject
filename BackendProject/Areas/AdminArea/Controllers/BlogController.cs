using BackendProject.Data;
using BackendProject.Helpers;
using BackendProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class BlogController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index() => View(await _context.Blogs.ToListAsync());

        [HttpGet]
        public IActionResult Create() => View();


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!ModelState.IsValid) return View();


            if (!blog.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View();
            }


            if (!blog.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + blog.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/blog", fileName);

            await Helper.SaveFile(path, blog.Photo);

            Blog newBlog = new Blog
            {
                Image = fileName,
                Title = blog.Title,
                By = blog.By,
                ArticleHeader = blog.ArticleHeader,
                ArticleContext = blog.ArticleContext,
                ArticleQuote = blog.ArticleQuote,
                Date = DateTime.Now.ToString()
            };


            await _context.Blogs.AddAsync(newBlog);


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            Blog blog = await GetByIdAsync(id);

            if (blog == null) return NotFound();

            //string path = Helper.GetFilePath(_env.WebRootPath, "img", blog.Image);

            //if (System.IO.File.Exists(path))
            //{
            //    System.IO.File.Delete(path);
            //}

            //Helper.DeleteFile(path);

            //_context.Blogs.Remove(blog);

            //await _context.SaveChangesAsync();
            blog.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Blog blog = await GetByIdAsync((int)id);

            if (blog == null) return NotFound();

            return View(blog);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Blog blog)
        {
            if (id is null) return BadRequest();

            if (blog.Photo == null) return RedirectToAction(nameof(Index));

            var dbBlog = await GetByIdAsync((int)id);

            if (dbBlog == null) return NotFound();

            if (!blog.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View(dbBlog);
            }

            if (!blog.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View(dbBlog);
            }

            string oldPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/blog", dbBlog.Image);

            Helper.DeleteFile(oldPath);

            string fileName = Guid.NewGuid().ToString() + "_" + blog.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/blog", fileName);


            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await blog.Photo.CopyToAsync(stream);
            }

            dbBlog.Image = fileName;
            dbBlog.Title = blog.Title;
            dbBlog.By = blog.By;
            dbBlog.ArticleHeader = blog.ArticleHeader;
            dbBlog.ArticleContext = blog.ArticleContext;
            dbBlog.ArticleQuote = blog.ArticleQuote;
            dbBlog.Date = DateTime.Now.ToString();

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Blog blog = await GetByIdAsync((int)id);

            if (blog == null) return NotFound();

            return View(blog);

        }


        private async Task<Blog> GetByIdAsync(int id)
        {
            return await _context.Blogs.FindAsync(id);
        }

    }
}
