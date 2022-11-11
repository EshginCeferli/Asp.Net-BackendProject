using BackendProject.Data;
using BackendProject.Models;
using BackendProject.ViewModels.TopHeaderViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class TopHeaderController : Controller
    {
        private readonly AppDbContext _context;

        public TopHeaderController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<TopHeader> topHeaders = await _context.TopHeaders.ToListAsync();
            return View(topHeaders);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TopHeaderCreateVM topHeaderCreateVM)
        {

            if (!ModelState.IsValid)
            {
                return View(topHeaderCreateVM);
            }


            TopHeader topHeader = new TopHeader()
            {
                Title = topHeaderCreateVM.Title,
                Description = topHeaderCreateVM.Description,
            };

            await _context.TopHeaders.AddAsync(topHeader);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            TopHeader dbTopHeader = await _context.TopHeaders.FirstOrDefaultAsync(m => m.Id == id);

            return View(new TopHeaderEditVM
            {
                Title = dbTopHeader.Title,
                Description = dbTopHeader.Description,
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TopHeaderEditVM updatedTopHeader)
        {
            TopHeader dbTopHeader = await _context.TopHeaders.FirstOrDefaultAsync(m => m.Id == id);


            dbTopHeader.Title = updatedTopHeader.Title;
            dbTopHeader.Description = updatedTopHeader.Description;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            TopHeader topHeader = await _context.TopHeaders
                .FirstOrDefaultAsync(m => m.Id == id);

            if (topHeader == null) return NotFound();

            topHeader.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            TopHeader topHeader = await _context.TopHeaders.FirstOrDefaultAsync(m => m.Id == id);

            TopHeaderDetailVM topHeaderDetail = new TopHeaderDetailVM()
            {
                Title = topHeader.Title,
                Description = topHeader.Description,

            };

            return View(topHeaderDetail);
        }
    }
}
