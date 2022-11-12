using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class BlogDetailVM
    {
        public Blog Blog { get; set; }
        public List<RecentBlog> RecentBlogs { get; set; }
        public Widget Widget { get; set; }
        public IEnumerable<Social> Socials { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
