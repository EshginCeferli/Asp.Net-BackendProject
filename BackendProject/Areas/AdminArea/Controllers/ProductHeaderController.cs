using BackendProject.Data;
using BackendProject.Models;
using BackendProject.ViewModels.ProductHeaderViewModels;
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
    public class ProductHeaderController : Controller
    {
        private readonly AppDbContext _context;

        public ProductHeaderController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<ProductHeader> productHeaders = await _context.ProductHeaders.ToListAsync();
            return View(productHeaders);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TopHeaderCreateVM productHeaderCreateVM)
        {

            if (!ModelState.IsValid)
            {
                return View(productHeaderCreateVM);
            }


            ProductHeader productHeader = new ProductHeader()
            {
                Header = productHeaderCreateVM.Title,
                Description = productHeaderCreateVM.Description,
            };

            await _context.ProductHeaders.AddAsync(productHeader);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            ProductHeader dbProductHeader = await _context.ProductHeaders.FirstOrDefaultAsync(m => m.Id == id);

            return View(new ProductHeaderEditVM
            {
                Title = dbProductHeader.Header,
                Description = dbProductHeader.Description,
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductHeaderEditVM updatedProductHeader)
        {
            ProductHeader dbProductHeader = await _context.ProductHeaders.FirstOrDefaultAsync(m => m.Id == id);


            dbProductHeader.Header = updatedProductHeader.Title;
            dbProductHeader.Description = updatedProductHeader.Description;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            ProductHeader productHeader = await _context.ProductHeaders
                .FirstOrDefaultAsync(m => m.Id == id);

            if (productHeader == null) return NotFound();

            productHeader.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            ProductHeader productHeader = await _context.ProductHeaders.FirstOrDefaultAsync(m => m.Id == id);

            ProductHeaderDetailVM productHeaderDetail = new ProductHeaderDetailVM()
            {
                Title = productHeader.Header,
                Description = productHeader.Description,

            };

            return View(productHeaderDetail);
        }
    }
}
