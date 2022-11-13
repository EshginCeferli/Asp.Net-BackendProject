using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Comment:BaseEntity
    {
        public string UserName { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public string Datetime { get; set; } = DateTime.Now.ToString();
        public Blog Blog { get; set; }
    }
}
