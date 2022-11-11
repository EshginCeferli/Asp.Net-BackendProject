using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels.LinkCreateViewModels
{
    public class LinkCreateVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        [Required(ErrorMessage = "Can't be empty")]
        public IFormFile Photo { get; set; }
    }
}
