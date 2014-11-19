using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FolwerLandBase {
	public class Employee :Person{
        public Employee()
        {
            EmployeeTypes = new List<EmployeType>();
        }
        //public Employee() {
        //    Orders = new List<Order>();
        //    //if(Job != JobType.Programmer) {
        //    //	Adds = null;
        //    //}
        //}

		//[Key]
		//public int EmployeeID { get; set; }

		//public PersonalProperties PersonalProperties { get; set; }

		//public ContactInfo ContactInfo { get; set; }

		//public JobType Job { get; set; }

		//public virtual ICollection<Order> Orders { get; set; }
		//public virtual ICollection<AddsBanner> Adds { get; set; }
        public virtual ICollection<EmployeType> EmployeeTypes { get; set; }
	}

	//public enum JobType {
	//	DeliveriesMan,
	//	Programmer,
	//	Manager
    //    //Tornike
	//}
    
}
