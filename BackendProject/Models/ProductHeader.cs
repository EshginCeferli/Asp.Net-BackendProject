using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class ProductHeader: BaseEntity
    {
        public string Header { get; set; }
        public string Description { get; set; }
        //public List<Product> Product { get; set; }
    }
}
