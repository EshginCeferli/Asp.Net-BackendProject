using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class ShopVM
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<Size> Sizes { get; set; }
    }
}
