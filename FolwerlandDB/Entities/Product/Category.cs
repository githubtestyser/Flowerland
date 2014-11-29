using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FlowerlandDB
{
  public class Category
    {
        [Key]
        [Required]
        public int ID { get; set; }

        public string Name { get; set; }

        IEnumerable<ProductTemplate> Products { get; set; }
    }
}
