using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolwerLandBase {
	public class Cart {
		public Cart() {
			Bouqet = new List<Bouqet>();
			Flowers = new List<Flower>();
			//SubTotalPrice = ...;
		}

		[Key]
		public int CartID { get; set; }

		[NotMapped]
		public int TotalItems {
			get {
				return Bouqet.Count + Flowers.Count;
			}
		}

		[DefaultValue(0)]
		public decimal SubTotalPrice { get; set; }

		public virtual Customer Customer { get; set; }
		public virtual ICollection<Bouqet> Bouqet { get; set; }
		public virtual ICollection<Flower> Flowers { get; set; }
	}
}
