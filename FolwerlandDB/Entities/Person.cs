using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerlandDB
{
    public class Person
    {
        public Person()
        {
            Orders = new List<Order>();
            Carts = new List<Cart>();
        }
        [Key]
        public int ID { get; set; }

        [Required]
        public PersonalProperties PersonalProperties { get; set; }

        [Required]
        public ContactInfo ContactInfo { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
