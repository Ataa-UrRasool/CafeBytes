using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer.Models
{
	internal class Item
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public float Price { get; set; }
		public string NutritionalInformation { get; set; }
		public int LoyaltyPointsPrice { get; set; }
		public int LoyaltyPointsReward { get; set; }
		
		public Item ()
		{ }

		public string InsertMenuItemQuery()
		{
			return "";
		}
	}
}
