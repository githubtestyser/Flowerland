using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FolwerLandBase
{
  public class Category
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }
        [MaxLength(20)]
        public string CategoryName { get; set; }

        public virtual ICollection<Bouqet> Bouqets { get; set; }
    }
}
