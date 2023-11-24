using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer.Models
{
	internal class Discount
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float Value { get; set; }
		public int Status { get; set; }

		public Discount()
		{
			Status = 1;
		}

		public string DiscountInsertQuery()
		{
			return "INSERT INTO Discounts (name, value, status) VALUES ( '" + Name + "' , '" + Value + "', '" + Status + "' )";
		}
	}
}
