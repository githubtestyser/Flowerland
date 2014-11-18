﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolwerLandBase
{
    public class CustomerType
    {
        public CustomerType()
        {
            Customer = new List<Customer>();
        }
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}