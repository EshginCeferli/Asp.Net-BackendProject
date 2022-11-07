using System;
using System.Collections.Generic;
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
    }
}
