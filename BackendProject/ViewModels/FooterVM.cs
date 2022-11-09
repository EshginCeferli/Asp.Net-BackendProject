using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class FooterVM
    {
        public IEnumerable<Social> Socials { get; set; }
        public Contact Contact { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
