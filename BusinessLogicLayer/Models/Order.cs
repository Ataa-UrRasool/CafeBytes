using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer.Models
{
	internal class Order
	{
		public int Id { get; set; }
		public List<int> Quantity { get; set; }
		public List<Item> ItemsList { get; set; }
		public float TotalAmount { get; set; }
		public int Status { get; set; }
		public Customer customer { get; set; }

		public Order() { }
	}
}
