using DbProject.DbContextLayer;
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

		public Order()
		{
			customer = new Customer();
			Id = new DAL().ExecuteGetCount(GetIDCount()) + 1;
			ItemsList = new List<Item>();
			Quantity = new List<int>();
		}

		public List<string> CreateInsertOrderQuery()
		{
			List<string> queries = new List<string>();
			for (int i = 0; i < ItemsList.Count; i++)
			{
				string query = "INSERT INTO Orders (orderID, menuItem, quantity, totalAmount, customerID, status) VALUES " +
					"('" + Id + "', '" + ItemsList[i].Id + "', '" + Quantity[i] + "', '" + ItemsList[i].Price + "', '" + customer.Id + "', '" + 1 + "');";


				queries.Add(query);
			}
			return queries;
		}
		public float calculateTotal()
		{
			float sum = 0;
			for (int i = 0; i < ItemsList.Count; i++)
			{
				sum += ItemsList[i].Price;
			}

			return sum;
		}

		public string GetIDCount()
		{
			return "SELECT COUNT(DISTINCT orderID) FROM Orders";
		}
	}
}
