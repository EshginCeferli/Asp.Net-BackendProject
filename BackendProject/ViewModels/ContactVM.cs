using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class ContactVM
    {
        public Contact Contact { get; set; }
        public Message Message { get; set; }
    }
}
