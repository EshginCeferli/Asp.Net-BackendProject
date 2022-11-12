using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Widget:BaseEntity
    {
        public string Image { get; set; }
        public string Fullname { get; set; }
        public string Role { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        //public Social Social { get; set; }
    }
}
