using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FolwerLandBase
{
  public  class Specie
    {
        [Key]
        public int SpecieID { get; set; }
        [MaxLength(25)]
        public string SpecieName { get; set; }

        public virtual ICollection<Flower> Flowers { get; set; }
    }
}
