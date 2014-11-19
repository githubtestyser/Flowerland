using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolwerLandBase {
	public class AddsBanner {
		[Key]
		public int AddID { get; set; }
		public DateTime ValidFrom { get; set; }
		public DateTime ValidUntil { get; set; }
        public bool IsValid { get; set; }

		//public State State { get; set; }
		public decimal RentPrice { get; set; }

		public Customer Customer { get; set; }
		public virtual ICollection<Employee> Employee { get; set; }
	}

    //public enum State {
    //    Valid,
    //    Expired
    //}
}
