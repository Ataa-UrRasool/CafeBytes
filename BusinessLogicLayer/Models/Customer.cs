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
	}
}
