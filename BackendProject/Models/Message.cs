﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Message : BaseEntity
    {
        //[Required]
        public string Name { get; set; }
        //[Required]
        public int Phone { get; set; }

        //[Required]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Required]
        public string Subject { get; set; }
        //[Required]
        public string Content { get; set; }

    }
}
