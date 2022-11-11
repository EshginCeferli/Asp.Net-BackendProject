using BackendProject.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> Create(SliderCreateVM slider)
        {
            if (!ModelState.IsValid) return View();


            if (!slider.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View();
            }


            if (!slider.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + slider.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", fileName);

            await Helper.SaveFile(path, slider.Photo);

            Slider newSlider = new Slider
            {
                Image = fileName,
                Title = slider.Title,
                Header = slider.Description,
                Description = slider.Description
            };


            await _context.Sliders.AddAsync(newSlider);


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await GetByIdAsync(id);

            if (slider == null) return NotFound();

            //string path = Helper.GetFilePath(_env.WebRootPath, "img", slider.Image);

            //if (System.IO.File.Exists(path))
            //{
            //    System.IO.File.Delete(path);
            //}

            //Helper.DeleteFile(path);

            //_context.Sliders.Remove(slider);

            //await _context.SaveChangesAsync();
            slider.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Slider slider = await GetByIdAsync((int)id);

            if (slider == null) return NotFound();

            return View(slider);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Slider slider)
        {
            if (id is null) return BadRequest();

            if (slider.Photo == null) return RedirectToAction(nameof(Index));

            var dbSlider = await GetByIdAsync((int)id);

            if (dbSlider == null) return NotFound();

            if (!slider.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View(dbSlider);
            }

            if (!slider.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View(dbSlider);
            }

            string oldPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", dbSlider.Image);

            Helper.DeleteFile(oldPath);

            string fileName = Guid.NewGuid().ToString() + "_" + slider.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", fileName);


            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await slider.Photo.CopyToAsync(stream);
            }

            dbSlider.Image = fileName;
            dbSlider.Title = slider.Title;
            dbSlider.Header = slider.Header;
            dbSlider.Description = slider.Description;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Slider slider = await GetByIdAsync((int)id);

            if (slider == null) return NotFound();

            return View(slider);

        }


        private async Task<Slider> GetByIdAsync(int id)
        {
            return await _context.Sliders.FindAsync(id);
        }

    }
}
