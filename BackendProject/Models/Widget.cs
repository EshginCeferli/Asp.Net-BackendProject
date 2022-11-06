using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Widget:BaseEntity
    {
        public string Image { get; set; }
        public string Fullname { get; set; }
        public string Role { get; set; }
        //public Social Social { get; set; }

    }
}
