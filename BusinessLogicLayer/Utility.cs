using DbProject.BusinessLogicLayer.Models;
using DbProject.DbContextLayer;
using System.Data;

namespace DbProject.BusinessLogicLayer
{
	internal class Utility
	{
		public List<Order> GetOrdersFromDB()
		{
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(GetOrdersQuery());

			List<Order> orders = new List<Order>();

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				Order order = new Order();
				order.Id = dt.Rows[i].Field<int>("orderID");
				order.ItemsList = GetOrderItems(order.Id);

				//				order.TotalAmount = dt.Rows[i].Field<float>("totalAmount");
				string totalPrice = dt.Rows[i]["totalAmount"].ToString();
				if (float.TryParse(totalPrice, out float price))
				{
					order.TotalAmount = price;
				}
				else
				{
					order.TotalAmount = float.Parse(totalPrice);
				}

				order.Status = dt.Rows[i].Field<int>("status");
				order.customer.Id = dt.Rows[i].Field<int>("customerID");

			}

			return orders;
		}
		//private List<Item> GetOrdersQuantity()
		//{
		//	string query = "SELECT quantity FROM Orders";

		//	DAL dAL = new DAL();
		//	DataTable dt = dAL.executeGetData(query);

		//	List<Item> ordersList = new List<Item>();
		//	for (int i = 0; i<dt.Rows.Count; i++)
		//	{
		//		Order order = new Order();
		//		order.Quantity[i] = dt.Rows[i].Field<int>("quantity");	
		//		ordersList.Add
		//	}

		//	return null;
		//}

		private List<Item> GetOrderItems(int orderID)
		{
			string query = "SELECT * FROM MenuItems INNER JOIN Orders ON orders.menuItem = MenuItems.ID";
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(query);

			List<Item> listItems = new List<Item>();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				Item newItem = new Item();
				newItem.Id = dt.Rows[i].Field<int>("ID");
				newItem.Name = dt.Rows[i].Field<string>("name");
				newItem.Description = dt.Rows[i].Field<string>("description");
				//newItem.Price = float.Parse( dt.Rows[i].Field<float>("price"));
				string priceStr = dt.Rows[i]["price"].ToString();
				if (float.TryParse(priceStr, out float price))
				{
					newItem.Price = price;
				}
				else
				{
					newItem.Price = float.Parse(priceStr);
				}

				newItem.LoyaltyPointsPrice = dt.Rows[i].Field<int>("loyaltyPointsPrice");
				newItem.LoyaltyPointsReward = dt.Rows[i].Field<int>("layaltyPointsReward");
				newItem.Tax = dt.Rows[i].Field<int>("tax");
				newItem.Discount = dt.Rows[i].Field<int>("discount");
				listItems.Add(newItem);
			}

			return listItems;
		}

		public bool VerifyID(int ID)
		{
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(MatchCustomerID(ID));

			if (dt.Rows.Count > 0)
			{
				return true;
			}
			else
			{ return false; }
		}
		public bool UsernameExists(string username)
		{
			DAL dAL = new DAL();
			int count = dAL.ExecuteGetCount(query(username));
			if (count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public string query(string username)
		{
			return "SELECT COUNT(ID) FROM Credentials WHERE username = '" + username + "';";
		}


		public List<Discount> GetDiscounts()
		{
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(GetDiscountsQuery());


			List<Discount> list = new List<Discount>();

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				Discount discount = new Discount()
				{
					Id = dt.Rows[i].Field<int>("ID"),
					Name = dt.Rows[i].Field<string>("name")

				};
				list.Add(discount);

			}

			return list;
		}
		public List<Tax> GetTaxes()
		{
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(GetTaxesQuery());


			List<Tax> list = new List<Tax>();

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				Tax tax = new Tax()
				{
					Id = dt.Rows[i].Field<int>("ID"),
					Name = dt.Rows[i].Field<string>("name")
				};
				list.Add(tax);
			}

			return list;
		}
		public List<Item> GetItems()
		{
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(GetItemsQuery());

			List<Item> itemsList = new List<Item>();

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				Item item = new Item();

				item.Id = dt.Rows[i].Field<int>("ID");
				item.Name = dt.Rows[i].Field<string>("name");
				item.Description = dt.Rows[i].Field<string>("description");
				//item.Price = dt.Rows[i].Field<float>("price");
				string priceStr = dt.Rows[i]["price"].ToString();
				if (float.TryParse(priceStr, out float price))
				{
					item.Price = price;
				}
				else
				{
					item.Price = float.Parse(priceStr);
				}

				item.NutritionalInformation = dt.Rows[i].Field<string>("nutritionalInfo");
				item.LoyaltyPointsPrice = dt.Rows[i].Field<int>("loyaltyPointsPrice");
				item.LoyaltyPointsReward = dt.Rows[i].Field<int>("layaltyPointsReward");
				item.Discount = dt.Rows[i].Field<int>("discount");
				item.Tax = dt.Rows[i].Field<int>("tax");

				itemsList.Add(item);
			}
			return itemsList;
		}
		private string GetItemsQuery()
		{
			return "SELECT * FROM MenuItems;";
		}
		private string GetDiscountsQuery()
		{
			return "SELECT ID, name FROM Discounts";
		}
		private string GetTaxesQuery()
		{
			return "SELECT ID, name FROM Taxes";
		}
		private string MatchCustomerID(int passedCustomerID)
		{
			return "SELECT ID FROM Customers WHERE ID = '" + passedCustomerID + "'";
		}
		private string GetOrdersQuery()
		{
			return "SELECT * FROM Orders";
		}
		public string UpdateMenuItems(int passedMenuID, string passedName, string passedPrice, string passedNutriInfo, string passedDesc, string passedLpPrice, string passedLpReward, string passedDiscount, string passedTax)
		{
			return "UPDATE MenuItems SET name = '" + passedName + "', description = '" + passedDesc + "', price = '" + passedPrice + "', nutritionalInfo = '" + passedNutriInfo + "', loyaltyPointsPrice = '" + passedLpPrice + "', layaltyPointsReward = '" + passedLpReward + "', discount = '" + passedDiscount + "', tax = '" + passedTax + "' WHERE ID = '" + passedMenuID + "';";
		}
	}
}
