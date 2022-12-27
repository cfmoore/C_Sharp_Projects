﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; } 
        [Required]
        public int Name { get; set; }
        public int Author { get; set; }
        public int ISBN { get; set; }

    }
}
