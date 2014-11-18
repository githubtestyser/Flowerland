using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FolwerLandBase {
	public class Customer:Person {
        public Customer()
        {
            CustomerTypes = new List<CustomerType>();
        }
        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}
			//if(this.Type == CustomerType.VIP) {
			//	foreach(var i in Orders) {
			//		foreach(var j in i.OrderDetails) {
			//			j.Discount = (decimal)0.8;
			//		}
			//	}
			   //else if(this.Type == CustomerType.GOD_OF_FLOWERS) {
				//foreach(var i in Orders) {
				//	foreach(var j in i.OrderDetails) {
				//		j.Discount = (decimal)0.5;
				//	}
				//}
			    //} 
		

		//[Key]
		//public int ID { get; set; }

		//[Required]
		//public CustomerType Type { get; set; }


		//public virtual ICollection<Cart> Carts { get; set; }
		//public virtual ICollection<Order> Orders { get; set; }
		//public virtual ICollection<AddsBanner> AddsBanner { get; set; }
        public virtual ICollection<CustomerType> CustomerTypes { get; set; }

	}

    //public	enum CustomerType {
	//	Member,
	//	VIP,
    //   GOD_OF_FLOWERS
	//}
}
