using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class RecentBlog :BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string By { get; set; }
        public string Date { get; set; }
    }
}
