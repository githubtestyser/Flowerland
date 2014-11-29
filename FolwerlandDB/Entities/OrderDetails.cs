using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolwerLandBase
{
    public class OrderDetails //NorthWind-is Magalitze Shevqmeni
    {

        [Key]
        public int OrderDetailID { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public uint Quantity { get; set; }

        [DefaultValue(0)]
        public decimal Discount { get; set; }

        [Required]
        public Order Order { get; set; }
    }
}
