using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerlandDB {
	[ComplexType]
	public class AddressInfo {
		[MaxLength(20), MinLength(4)]
		public string Country { get; set; }

		[MaxLength(20), MinLength(2)]
		public string Town { get; set; }

		[MaxLength(25), MinLength(10)]
		public string Address { get; set; }

		[MaxLength(5), MinLength(5)]
		public string ZIP { get; set; }
	}

	[ComplexType]
	public class ContactInfo {
		public string Phone { get; set; }

		public string Mobile { get; set; }

		public string Email { get; set; }
	}

	[ComplexType] //very, very complex! :D
	public class PersonalProperties {
		public PersonalProperties() {
			if(Age > 120 || Age < 17) {
				Status = Status.Inactive;
			} else if(Gender == Gender.NotSpecified) {
				Status = Status.Inactive;
			} else if(CreditCardNumber == String.Empty) {
				Status = Status.Inactive;
			} else {
				Status = Status.Active;
			}

			TimeSpan tempTS = DateTime.Now - DateOfBirth;

			this.Age = (int)(tempTS.TotalDays / 365);
		}

		[MaxLength(20), MinLength(2), Required]
		public string Firstname { get; set; }

		[MaxLength(25), MinLength(2), Required]
		public string Lastname { get; set; }

		[MaxLength(11), MinLength(11)]
		public string SSN { get; set; }

		[MaxLength(20), MinLength(20)]
		public string CreditCardNumber { get; set; }

		[DefaultValue(-1)]
		public int Age { get; set; }

		public DateTime DateOfBirth { get; set; }

		[DefaultValue(Gender.NotSpecified)]
		public Gender Gender { get; set; }

		[DefaultValue(Status.Inactive)]
		public Status Status { get; set; }
	}

	public enum Gender {
		NotSpecified = -1,
		Male = 1,
		Female = 0
	}

	public enum Status {
		Inactive = -1,
		Resigned = 0,
		Active = 1
	}
}
