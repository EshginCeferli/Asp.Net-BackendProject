using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Banner:BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Image { get; set; }
    }
}
