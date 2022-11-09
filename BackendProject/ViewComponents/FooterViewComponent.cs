using BackendProject.Data;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            IEnumerable<Social> socials = await _context.Socials.ToListAsync();
            Contact contact = await _context.Contacts.FirstOrDefaultAsync();
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();


            FooterVM footerVM = new FooterVM
            {
                Socials = socials,
                Contact = contact,
                Categories = categories
            };


            return await Task.FromResult(View(footerVM));
        }
    }

  
}
