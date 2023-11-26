using DbProject.BusinessLogicLayer.Models;
using DbProject.DbContextLayer;
using System.Data;

namespace DbProject.BusinessLogicLayer
{
	internal class Utility
	{

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

	}
}
