using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Discount { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public int? SellCount { get; set; }
        public string Description { get; set; }
        //public int ProductHeaderId { get; set; }
        //public ProductHeader ProductHeader { get; set; }
    }
}
