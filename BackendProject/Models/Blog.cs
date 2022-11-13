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
        [Required]
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public  string By { get; set; }      
        public string Date { get; set; } = DateTime.Now.ToString();
        [Required]
        public string ArticleHeader { get; set; }
        [Required]
        public string ArticleQuote { get; set; }
        [Required]
        public string ArticleContext { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Can't be empty")]
        public IFormFile Photo { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
