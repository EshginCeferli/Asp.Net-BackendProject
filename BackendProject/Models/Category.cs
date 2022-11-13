using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public List<Product> Product { get; set; }        
    }
}
