using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Size:BaseEntity
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
