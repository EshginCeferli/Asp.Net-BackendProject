using BackendProject.Data;
using BackendProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Contact Contact = await _context.Contacts.FirstOrDefaultAsync();
            return View(Contact);
        }       

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Contact dbContact = await _context.Contacts.FirstOrDefaultAsync(m => m.Id == id);

            return View(dbContact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Contact updatedContact)
        {
            Contact dbContact = await _context.Contacts.FirstOrDefaultAsync(m => m.Id == id);


            dbContact.Title = updatedContact.Title;
            dbContact.Description = updatedContact.Description;
            dbContact.Address = updatedContact.Address;
            dbContact.Mail = updatedContact.Mail;
            dbContact.Phone = updatedContact.Phone;
            dbContact.WorkHour = updatedContact.WorkHour;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Contact Contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Contact == null) return NotFound();

            Contact.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Contact contact = await _context.Contacts.FirstOrDefaultAsync(m => m.Id == id);
                        
            return View(contact);
        }
    }
}
