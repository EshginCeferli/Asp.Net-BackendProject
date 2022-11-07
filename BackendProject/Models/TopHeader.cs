using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class TopHeader:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
