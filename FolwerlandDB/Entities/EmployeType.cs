using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerlandDB
{
    public class EmployeType
    {
        public EmployeType()
        {
            Employee = new List<Employee>();
        }
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
