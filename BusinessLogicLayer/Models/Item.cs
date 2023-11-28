using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer.Models
{
	internal class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public float Price { get; set; }
		public string NutritionalInformation { get; set; }
		public int LoyaltyPointsPrice { get; set; }
		public int LoyaltyPointsReward { get; set; }
		public int Discount { get; set; }
		public int Tax { get; set; }

		public Item()
		{ }

		public string InsertMenuItemQuery()
		{
			return "INSERT INTO MenuItems (name, description, price, nutritionalInfo, loyaltyPointsPrice, layaltyPointsReward, discount, tax) " +
					" VALUES ( '" + Name + "', '" + Description + "', '" + Price + "', '" + NutritionalInformation + "', '" + LoyaltyPointsPrice + 
					"', '" + LoyaltyPointsReward + "', '" + Discount + "', '" + Tax + "')";
		}
	}
}
