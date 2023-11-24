using DbProject.BusinessLogicLayer.Models;
using DbProject.DbContextLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer
{
	internal class MenuCreation
	{
		public void AddMenuItem(Item item)
		{
			DAL dAL = new DAL();
			int x = dAL.Insert(item.InsertMenuItemQuery());

			if (x > 0)
			{
				MessageBox.Show("Item added in the menu");
			}
			else
			{
				MessageBox.Show("Error while adding item in the menu");
			}
		}

	}
}
