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
