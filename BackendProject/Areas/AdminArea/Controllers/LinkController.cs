using BackendProject.Data;
using BackendProject.Helpers;
using BackendProject.Models;
using BackendProject.ViewModels.LinkCreateViewModels;
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
    public class LinkController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public LinkController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index() => View(await _context.Links.ToListAsync());

        [HttpGet]
        public IActionResult Create() => View();


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LinkCreateVM link)
        {
            if (!ModelState.IsValid) return View();


            if (!link.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View();
            }


            if (!link.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + link.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/icon", fileName);

            await Helper.SaveFile(path, link.Photo);

            Link newLink = new Link
            {
                Image = fileName,
                Title = link.Title,
                Description = link.Description,
                Color = link.Color
            };


            await _context.Links.AddAsync(newLink);


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            Link link = await GetByIdAsync(id);

            if (link == null) return NotFound();

          
            link.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Link link = await _context.Links.FindAsync(id);
            if (link == null) return NotFound();

            LinkEditVM linkEditVM = new LinkEditVM
            {
                Image = link.Image,
                Photo = link.Photo,
                Title = link.Title,
                Description = link.Description,
                Color = link.Color
            };
                

            return View(linkEditVM);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Link link)
        {
            if (id is null) return BadRequest();

            if (link.Photo == null) return RedirectToAction(nameof(Index));

            var dbLink = await GetByIdAsync((int)id);

            if (dbLink == null) return NotFound();

            if (!link.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View(dbLink);
            }

            if (!link.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View(dbLink);
            }

            string oldPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/icon", dbLink.Image);

            Helper.DeleteFile(oldPath);

            string fileName = Guid.NewGuid().ToString() + "_" + link.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/icon", fileName);


            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await link.Photo.CopyToAsync(stream);
            }

            dbLink.Image = fileName;
            dbLink.Title = link.Title;
            dbLink.Color = link.Color;
            dbLink.Description = link.Description;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Link link = await GetByIdAsync((int)id);

            if (link == null) return NotFound();

            return View(link);
        }


        private async Task<Link> GetByIdAsync(int id)
        {
            return await _context.Links.FindAsync(id);
        }

    }
}
