﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolwerlandDB.Entities.Product
{
    class Property
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}