using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FolwerlandDB.Entities.Product
{
  public class Category
    {
        [Key]
        [Required]
        public int ID { get; set; }

        public string Name { get; set; }

        IEnumerable<ProductTmplate> Products { get; set; }
    }
}
