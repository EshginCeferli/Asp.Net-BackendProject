using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Comment:BaseEntity
    {
        public string UserName { get; set; }
        //[Required]
        public string Content { get; set; }
        public int BlogId { get; set; }
        public string Datetime { get; set; } = DateTime.Now.ToString();
        public int Count { get; set; }
        public Blog Blog { get; set; }
    }
}
