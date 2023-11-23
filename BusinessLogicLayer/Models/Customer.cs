using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer.Models
{
	internal class Customer : Person
	{
		public int LoyaltyPoints { get; set; }
		public Customer()
		{
			LoyaltyPoints = 0;
		}

		public string CreateInsertQuery()
		{
			if (Gender.ToUpper() == Constants.GENDER_MALE)
			{
				return "INSERT INTO Employees (name, phoneNo, email, address, gender, LoyaltyPoints)" +
					" VALUES ('" + Name + "', '" + PhoneNumber + "', '" + Email + "', '" + Address + "', '" + 1 + "', '" + 0 + "');";
			}
			else
			{
				return "INSERT INTO Employees (name, phoneNo, email, address, gender, LoyaltyPoints)" +
					" VALUES ('" + Name + "', '" + PhoneNumber + "', '" + Email + "', '" + Address + "', '" + 2 + "', '" + 0 + "');";
			}
		}
	}
}
