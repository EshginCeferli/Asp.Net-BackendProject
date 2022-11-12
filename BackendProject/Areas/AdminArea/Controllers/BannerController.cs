using BackendProject.Data;
using BackendProject.Helpers;
using BackendProject.Models;
using BackendProject.ViewModels.BannerViewModels;
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
    public class BannerController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BannerController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index() => View(await _context.Banners.ToListAsync());

        [HttpGet]
        public IActionResult Create() => View();


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BannerCreateVM banner)
        {
            if (!ModelState.IsValid) return View();


            if (!banner.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View();
            }


            if (!banner.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + banner.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/banner", fileName);

            await Helper.SaveFile(path, banner.Photo);

            Banner newBanner = new Banner
            {
                Image = fileName,
                Title = banner.Title,
                Subtitle = banner.Subtitle

            };


            await _context.Banners.AddAsync(newBanner);


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            Banner banner = await GetByIdAsync(id);

            if (banner == null) return NotFound();

           
            banner.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Banner banner = await GetByIdAsync((int)id);

            if (banner == null) return NotFound();

            return View(banner);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Banner banner)
        {
            if (id is null) return BadRequest();

            if (banner.Photo == null) return RedirectToAction(nameof(Index));

            var dbBanner = await GetByIdAsync((int)id);

            if (dbBanner == null) return NotFound();

            if (!banner.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View(dbBanner);
            }

            if (!banner.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View(dbBanner);
            }

            string oldPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/banner", dbBanner.Image);

            Helper.DeleteFile(oldPath);

            string fileName = Guid.NewGuid().ToString() + "_" + banner.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/banner", fileName);


            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await banner.Photo.CopyToAsync(stream);
            }

            dbBanner.Image = fileName;
            dbBanner.Title = banner.Title;
            dbBanner.Subtitle = banner.Subtitle;         

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Banner banner = await GetByIdAsync((int)id);

            if (banner == null) return NotFound();

            return View(banner);

        }


        private async Task<Banner> GetByIdAsync(int id)
        {
            return await _context.Banners.FindAsync(id);
        }

    }
}
