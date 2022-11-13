using BackendProject.Data;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Contact contact = await _context.Contacts.FirstOrDefaultAsync();
            Message message = await _context.Messages.FirstOrDefaultAsync();

            ContactVM contactVM = new ContactVM
            {
                Contact = contact,
                Message = message
            };
            return View(contactVM);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> SendMessage(Message newMessage)
        {
            //IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
            
            Message message = new Message()
            {
                Name = newMessage.Name,
                Phone = newMessage.Phone,
                Email = newMessage.Email,
                Subject = newMessage.Subject,
                Content = newMessage.Content
            };

            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();

            return View();
        }
    }
}
