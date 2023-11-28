using DbProject.BusinessLogicLayer;
using DbProject.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProject.PresentationLayer
{
	public partial class EmployeeScreen : Form
	{
		private List<Order> ordersList = new List<Order>();
		private Customer customer = new Customer();
		public EmployeeScreen()
		{
			InitializeComponent();



			lv_allOrdersPanel.Columns.Add("Order ID");
			lv_allOrdersPanel.Columns.Add("Customer Name");

		}

		public void GetOrdersForOrderManager()
		{


		}


		private void btn_createProfile_Click(object sender, EventArgs e)
		{
			Customer customer = new Customer();
			customer.Name = txt_name.Text;
			customer.Email = txt_email.Text;
			customer.PhoneNumber = txt_phoneNo.Text;
			customer.Gender = cmb_gender.Text;
			customer.Address = txt_address.Text;

			customer.Username = txt_username.Text;
			customer.Password = txt_password.Text;

			UserCreation userCreation = new UserCreation();
			userCreation.CreateCustomer(customer);
		}

		private void tab_orderManager_Enter(object sender, EventArgs e)
		{
			Utility utility = new Utility();
			ordersList = utility.GetOrdersFromDB();

			lv_allOrdersPanel.View = View.Details;

			for (int i = 0; i < ordersList.Count; i++)
			{
				int oId = ordersList[i].Id;
				Customer customer = new Utility().GetCustomerInfoByID(oId);
				

				string[] values = { oId.ToString(), customer.Name.ToString() };
				var listViewItem = new ListViewItem(values);
				lv_allOrdersPanel.Items.Add(listViewItem);
			}

		}

	}
}
