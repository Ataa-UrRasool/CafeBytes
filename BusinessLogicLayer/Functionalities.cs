using DbProject.DbContextLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer
{
	public struct OrderInfor
	{
		public string itemName { get; set; }
		public double price { get; set; }
		public double discountValue { get; set; }
		public string customerName { get; set; }
		public OrderInfor()
		{
			itemName = string.Empty;
			price = 0;
			discountValue = 0;
			customerName = string.Empty;
		}
	}

	public struct SalesInfor
	{

	}
	public class Functionalities
	{

		public Functionalities() { }

		public List<OrderInfor> GetOrdersInfoForReports()
		{
			DataTable dt = new DataTable();
			dt = new DAL().executeGetData(GetOrdersInfoQuery());
			List<OrderInfor> ordersInfoList = new List<OrderInfor>();


			for (int i = 0; i < dt.Rows.Count; i++)
			{
				OrderInfor orderInfor = new OrderInfor();

				orderInfor.itemName = dt.Rows[i].Field<string>("MenuItemName");
				orderInfor.price = dt.Rows[i].Field<double>("price");
				orderInfor.discountValue = dt.Rows[i].Field<double>("DiscountValue");
				orderInfor.customerName = dt.Rows[i].Field<string>("CustomerName");

				ordersInfoList.Add(orderInfor);
			}

			return ordersInfoList;
			//dataGridView.Columns.Add();
		}
		public List<SalesInfor> GetSalesInforForReports()
		{

			return null;
		}


		private string GetOrdersInfoQuery()
		{
			//return "SELECT * FROM Orders";
			return "SELECT MenuItems.name AS MenuItemName, MenuItems.price, Discounts.value AS DiscountValue,  Customers.name AS CustomerName FROM MenuItems " +
				"LEFT JOIN Discounts ON MenuItems.discount = Discounts.ID JOIN Orders ON MenuItems.ID = Orders.menuItem " +
				"JOIN Customers ON Orders.customerID = Customers.ID WHERE MenuItems.discount IS NOT NULL;";

		}
	}
}

