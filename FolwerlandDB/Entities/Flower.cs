using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.IO;

namespace FolwerLandBase
{
 public class Flower
    {
        public Flower()
        {
            Bouqets = new List<Bouqet>();
        }

        [Key]
        //[Required]
        public int FlowerID { get; set; }

        //[MaxLength(20)]
        [MaxLength(50)]
        [Required]
        public string FlowerName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [DefaultValue("Not Specified")]
        public string History { get; set; }

        //public int Votes { get; set; }

        public byte[] Image { get; set; }

        public Specie Specie { get; set; }
        public virtual ICollection<Bouqet> Bouqets { get; set; }
    }
}
