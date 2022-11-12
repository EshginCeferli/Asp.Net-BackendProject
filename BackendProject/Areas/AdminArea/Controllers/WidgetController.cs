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
    public class WidgetController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public WidgetController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            Widget relatedHeader = await _context.Widgets.FirstOrDefaultAsync();
            return View(relatedHeader);
        }
     
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Widget updatedWidget = await _context.Widgets.FirstOrDefaultAsync(m => m.Id == id);

            return View(updatedWidget);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Widget updatedWidget)
        {            
            if (id is null) return BadRequest();

            if (updatedWidget.Photo == null) return RedirectToAction(nameof(Index));

            Widget dbWidget = await _context.Widgets.FirstOrDefaultAsync(m => m.Id == id);

            if (dbWidget == null) return NotFound();

            if (!updatedWidget.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View(dbWidget);
            }

            if (!updatedWidget.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View(dbWidget);
            }

            string oldPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/updatedWidget", dbWidget.Image);

            Helper.DeleteFile(oldPath);

            string fileName = Guid.NewGuid().ToString() + "_" + updatedWidget.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/updatedWidget", fileName);


            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await updatedWidget.Photo.CopyToAsync(stream);
            }

            dbWidget.Image = fileName;
            dbWidget.Fullname = updatedWidget.Fullname;
            dbWidget.Role = updatedWidget.Role;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Widget relatedHeader = await _context.Widgets
                .FirstOrDefaultAsync(m => m.Id == id);

            if (relatedHeader == null) return NotFound();

            relatedHeader.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Widget widget = await _context.Widgets.FirstOrDefaultAsync(m => m.Id == id);

          
            return View(widget);
        }
    }
}
