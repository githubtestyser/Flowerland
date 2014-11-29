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

        public virtual ICollection<EmployeType> EmployeeTypes { get; set; }
	}    
}
