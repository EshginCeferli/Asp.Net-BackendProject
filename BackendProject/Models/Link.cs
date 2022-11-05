using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Link : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
