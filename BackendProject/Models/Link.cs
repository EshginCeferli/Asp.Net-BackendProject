using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Link : BaseEntity
    {
        
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Can't be empty")]
        public IFormFile Photo { get; set; }
    }

  
}
