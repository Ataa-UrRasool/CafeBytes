using DbProject.BusinessLogicLayer.Models;
using DbProject.DbContextLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer
{
	internal class OrderManagement
	{
		public void CreateOrder(Order order)
		{
			DAL dAL = new DAL();
			List<string> queries = order.CreateInsertOrderQuery();

			for (int i = 0; i < queries.Count; i++)
			{
				dAL.Insert(queries[i]);
			}
		}
	}
}
