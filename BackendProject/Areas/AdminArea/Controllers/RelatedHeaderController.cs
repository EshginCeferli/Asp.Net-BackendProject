using BackendProject.Data;
using BackendProject.Models;
using BackendProject.ViewModels.RelatedHeaderViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class RelatedHeaderController : Controller
    {
        private readonly AppDbContext _context;

        public RelatedHeaderController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<RelatedHeader> relatedHeaders = await _context.RelatedHeaders.ToListAsync();
            return View(relatedHeaders);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RelatedHeaderCreateVM relatedHeaderCreateVM)
        {

            if (!ModelState.IsValid)
            {
                return View(relatedHeaderCreateVM);
            }


            RelatedHeader relatedHeader = new RelatedHeader()
            {
                Title = relatedHeaderCreateVM.Title,
                Description = relatedHeaderCreateVM.Description,
            };

            await _context.RelatedHeaders.AddAsync(relatedHeader);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            RelatedHeader dbRelatedHeader = await _context.RelatedHeaders.FirstOrDefaultAsync(m => m.Id == id);

            return View(new RelatedHeaderEditVM
            {
                Title = dbRelatedHeader.Title,
                Description = dbRelatedHeader.Description,
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, RelatedHeaderEditVM updatedRelatedHeader)
        {
            RelatedHeader dbRelatedHeader = await _context.RelatedHeaders.FirstOrDefaultAsync(m => m.Id == id);


            dbRelatedHeader.Title = updatedRelatedHeader.Title;
            dbRelatedHeader.Description = updatedRelatedHeader.Description;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            RelatedHeader relatedHeader = await _context.RelatedHeaders
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

            RelatedHeader relatedHeader = await _context.RelatedHeaders.FirstOrDefaultAsync(m => m.Id == id);

            RelatedHeaderDetailVM relatedHeaderDetail = new RelatedHeaderDetailVM()
            {
                Title = relatedHeader.Title,
                Description = relatedHeader.Description,

            };

            return View(relatedHeaderDetail);
        }
    }
}
