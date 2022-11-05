using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Slider : BaseEntity
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
