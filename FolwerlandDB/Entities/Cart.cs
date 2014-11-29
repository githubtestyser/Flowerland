using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FlowerlandDB {
	public class Cart {

		[Key]
		public int CartID { get; set; }

		//[NotMapped]
		//public int TotalItems {
		//	get {
		//		return Bouqet.Count + Flowers.Count;
		//	}
		//}

		[DefaultValue(0)]
		public decimal SubTotalPrice { get; set; }

		public virtual Customer Customer { get; set; }
	}
}
