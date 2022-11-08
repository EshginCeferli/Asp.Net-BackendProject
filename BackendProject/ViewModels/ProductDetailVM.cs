using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class ProductDetailVM
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
        public List<Social> Socials { get; set; }
        public RelatedHeader RelatedHeader { get; set; }
    }
}
