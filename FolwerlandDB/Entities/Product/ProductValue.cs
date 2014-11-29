using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolwerlandDB.Entities.Product
{
    class ProductValue
    {
        [Key]
        [Required]
        public int ID { get; set; }

        public DateTime DateValue { get; set; }
        // ათწილადის ჩაწერა დაგვჭირდება (მაგ.: წონა: 4.65 კგ)
        public decimal NumberValue { get; set; }
        public string TextValue { get; set; }
        public object Value { get; set; }

        public ProductProperty Property { get; set; }
    }
}
