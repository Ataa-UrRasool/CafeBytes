using DbProject.BusinessLogicLayer.Models;
using DbProject.DbContextLayer;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace DbProject.BusinessLogicLayer
{
	internal class Utility
	{

		public List<Employee> GetAllEmployees()
		{
			string query = "SELECT * FROM Employees";
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(query);

			List<Employee> employeesList = new List<Employee>();

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				Employee employee = new Employee();
				employee.ID = dt.Rows[i].Field<int>("ID");
				employee.Name = dt.Rows[i].Field<string>("name");
				employee.PhoneNumber = dt.Rows[i].Field<string>("phoneNo");
				employee.Email = dt.Rows[i].Field<string>("email");
				employee.Gender = dt.Rows[i].Field<int>("gender").ToString();
				employee.Address = dt.Rows[i].Field<string>("address");
				string hourlyRateStr = dt.Rows[i]["hourlyRate"].ToString();
				if (float.TryParse(hourlyRateStr, out float hrly))
				{
					employee.HourlyRate = hrly;
				}
				else
				{
					employee.HourlyRate = float.Parse(hourlyRateStr);
				}

				employee.Role = dt.Rows[i].Field<int>("role").ToString();
				employee.CredentialID = dt.Rows[i].Field<int>("credential");
				employeesList.Add(employee);
			}

			return employeesList;
		}
		public string GetCustomerNameFromOrder(int cID)
		{
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(GetCustomerNameFromOrderQuery(cID));
			return dt.Rows[0].Field<string>("name");
		}
		public string GetItemsQuantityFromOrdersQuery(int oID)
		{
			return "SELECT MenuItems.name, orders.quantity FROM Orders JOIN MenuItems ON Orders.menuItem = MenuItems.ID WHERE Orders.orderID = '" + oID + "'";
		}
		public List<Order> GetOrdersFromDB()
		{
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(GetOrdersQuery());

			List<Order> orders = new List<Order>();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				string query = "SELECT menuItem, quantity FROM Orders WHERE orderID = '" + dt.Rows[i].Field<int>("orderID") + "'";
				DataTable itemDT = dAL.executeGetData(query);

				Order order = new Order();
				order.Id = dt.Rows[i].Field<int>("orderID");

				string customerIdFromOrderIdQuery = "SELECT DISTINCT customerID FROM Orders WHERE orderID = '" + order.Id + "'";
				DataTable customerIdFromOrderIdDT = dAL.executeGetData(customerIdFromOrderIdQuery);

				order.customer.Id = customerIdFromOrderIdDT.Rows[0].Field<int>("customerID");

				for (int j = 0; j < itemDT.Rows.Count; j++)
				{
					string menuItemsQuery = "SELECT * FROM MenuItems WHERE ID = '" + itemDT.Rows[j].Field<int>("menuItem") + "'";
					DataTable menuDTall = dAL.executeGetData(menuItemsQuery);

					for (int k = 0; k < menuDTall.Rows.Count; k++)
					{
						Item item = new Item();
						item.Id = menuDTall.Rows[k].Field<int>("ID");
						item.Name = menuDTall.Rows[k].Field<string>("name");

						order.ItemsList.Add(item);
						order.Quantity.Add(itemDT.Rows[j].Field<int>("quantity"));
					}
				}
				orders.Add(order);
			}


			return orders;
		}

		public List<(string, double, int)> GetItemNamePriceQauntity(int oID)
		{
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(GetItemNamePriceQauntityQuery(oID));

			List<(string, double, int)> list = new List<(string, double, int)>();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				string name = dt.Rows[i].Field<string>("name");
				double price = dt.Rows[i].Field<double>("price");
				int quantity = dt.Rows[i].Field<int>("quantity");

				//List<(string, int, int)> list = new List<(string, int, int)>();
				list.Add((name, price, quantity));

			}
			return list;
		}

		public string GetCustomerName(int cID)
		{
			string query = "SELECT name FROM customers WHERE ID = '" + cID + "'";
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(query);

			return dt.Rows[0].Field<string>("name");
		}
		public Customer GetCustomerInfoByID(int cID)
		{
			string query = "SELECT * FROM Customers WHERE ID = '" + cID + "'";

			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(query);

			Customer customer = new Customer();
			customer.Id = cID;
			customer.Name = dt.Rows[0].Field<string>("name");
			customer.PhoneNumber = dt.Rows[0].Field<string>("phoneNo");
			customer.Email = dt.Rows[0].Field<string>("email");
			customer.Address = dt.Rows[0].Field<string>("address");
			customer.Gender = dt.Rows[0].Field<int>("gender").ToString();
			customer.LoyaltyPoints = dt.Rows[0].Field<int>("loyaltyPoints");

			return customer;
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
		public string[] GetDiscountTaxNames(int dID, int tID)
		{
			DAL dAL = new DAL();
			string[] names = dAL.GetTaxDiscountNames(GetDiscountTaxNameQuery(dID, tID));
			//string name = dt.Rows[0].Field<string>("name");

			//string[] discountTaxNames = { dt.Rows[0].Field<string>("dName"), dt.Rows[0].Field<string>("tName") };

			//return discountTaxNames;
			return null;
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


		public string query(string username)
		{
			return "SELECT COUNT(ID) FROM Credentials WHERE username = '" + username + "';";
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
			return "SELECT DISTINCT orderID FROM Orders";
		}
		private string GetCustomerNameFromOrderQuery(int customerID)
		{
			return "SELECT name FROM customers c INNER JOIN orders o ON c.'" + customerID + "' = o.customerID";
		}
		public string UpdateMenuItems(int passedMenuID, string passedName, string passedPrice, string passedNutriInfo, string passedDesc, string passedLpPrice, string passedLpReward, string passedDiscount, string passedTax)
		{
			return "UPDATE MenuItems SET name = '" + passedName + "', description = '" + passedDesc + "', price = '" + passedPrice + "', nutritionalInfo = '" + passedNutriInfo + "', loyaltyPointsPrice = '" + passedLpPrice + "', layaltyPointsReward = '" + passedLpReward + "', discount = '" + passedDiscount + "', tax = '" + passedTax + "' WHERE ID = '" + passedMenuID + "';";
		}
		private string GetDiscountTaxNameQuery(int dID, int tID)
		{
			return "SELECT d.name AS dName, t.name AS tName FROM Discounts d JOIN Taxes t ON d.ID = t.ID WHERE d.ID = '" + dID + "' AND t.ID = '" + tID + "' ";
		}
		private string GetItemNamePriceQauntityQuery(int oID)
		{
			return "SELECT MenuItems.name, MenuItems.price, orders.quantity FROM Orders JOIN MenuItems ON Orders.menuItem = MenuItems.ID WHERE Orders.orderID = '" + oID + "'";
		}

	}
}
