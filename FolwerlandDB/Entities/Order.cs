using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FlowerlandDB {
	public class Order {
		public Order() {
			DateOfOrder = DateTime.Now;

			OrderDetails = new List<OrderDetails>();

			//foreach (var i in OrderDetails)
			//{
			//    TotalPrice = TotalPrice + (i.Quantity * i.UnitPrice * i.Discount) + i.AdditionalPayments.ServicePrice + i.AdditionalPayments.VasePrice;
			//}

		}

		[Key, Required]
		public int OrderID { get; set; }

		[Required]
		public DateTime DateOfOrder { get; private set; }

		[DefaultValue(0)]
		public decimal TotalPrice { get; set; }

		[DefaultValue(OrderState.Active)]
		public OrderState State { get; set; }

		[Required]
		public Customer Client { get; set; }

		[Required]
		public Employee Employee { get; set; }

		[Required]
		public decimal ServicePrice { get; set; }

		[Required]
		public virtual ICollection<OrderDetails> OrderDetails { get; set; }
	}

public	enum OrderState {
		Failed = -1,
		Cancelled = 0,
		Active = 1,
		Finished = 2
	}
}
