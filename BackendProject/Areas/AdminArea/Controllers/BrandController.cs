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
    public class BrandController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BrandController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index() => View(await _context.Brands.ToListAsync());

        [HttpGet]
        public IActionResult Create() => View();


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Brand brand)
        {
            if (!ModelState.IsValid) return View();


            if (!brand.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View();
            }


            if (!brand.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + brand.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/brand", fileName);

            await Helper.SaveFile(path, brand.Photo);

            Brand newBrand = new Brand
            {
                Image = fileName               
            };


            await _context.Brands.AddAsync(newBrand);


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            Brand brand = await GetByIdAsync(id);

            if (brand == null) return NotFound();
            
            brand.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Brand brand = await GetByIdAsync((int)id);

            if (brand == null) return NotFound();

            return View(brand);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Brand brand)
        {
            if (id is null) return BadRequest();

            if (brand.Photo == null) return RedirectToAction(nameof(Index));

            var dbBrand = await GetByIdAsync((int)id);

            if (dbBrand == null) return NotFound();

            if (!brand.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View(dbBrand);
            }

            if (!brand.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View(dbBrand);
            }

            string oldPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/brand", dbBrand.Image);

            Helper.DeleteFile(oldPath);

            string fileName = Guid.NewGuid().ToString() + "_" + brand.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/brand", fileName);


            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await brand.Photo.CopyToAsync(stream);
            }

            dbBrand.Image = fileName;
            
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Brand brand = await GetByIdAsync((int)id);

            if (brand == null) return NotFound();

            return View(brand);

        }


        private async Task<Brand> GetByIdAsync(int id)
        {
            return await _context.Brands.FindAsync(id);
        }

    }
}
