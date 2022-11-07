using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Link> Links { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public ProductHeader ProductHeader { get; set; }
        public IEnumerable<Banner> Banners { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public BlogHeader BlogHeader { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public TopHeader TopHeader { get; set; }
    }
}
