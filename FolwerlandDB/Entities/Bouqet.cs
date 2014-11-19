using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FolwerLandBase {
	public class Bouqet {
		[Key]
		[Required]
		public int BouquetID { get; set; }

		[Required]
		public decimal Price { get; set; }

		[DefaultValue("No Description Available")]
		public string Description { get; set; }

		public byte[] Image { get; set; }

		public Category Category { get; set; }
		public virtual ICollection<OrderDetails> Order { get; set; }
		public virtual ICollection<Flower> Flowers { get; set; }
	}
}
