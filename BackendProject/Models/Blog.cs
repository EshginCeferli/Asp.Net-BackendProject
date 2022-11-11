using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Blog:BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public  string By { get; set; }
        public string Date { get; set; } = DateTime.Now.ToString();
        public string ArticleHeader { get; set; }
        public string ArticleQuote { get; set; }
        public string ArticleContext { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Can't be empty")]
        public IFormFile Photo { get; set; }
    }
}
