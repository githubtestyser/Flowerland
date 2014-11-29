using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerlandDB
{
    class ProductProperty
    {
        [Key]
        [Required]
        public int ID { get; set; }

        public int Position { get; set; }

        public Property Property { get; set; }
    }
}