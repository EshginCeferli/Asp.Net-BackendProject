using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Color: BaseEntity
    {
        public string Name { get; set; }
        public string Count { get; set; }
    }
}
