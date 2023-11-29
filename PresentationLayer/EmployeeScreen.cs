using DbProject.BusinessLogicLayer;
using DbProject.BusinessLogicLayer.Models;
using DbProject.DbContextLayer;
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
		Customer customer;
		private List<Order> ordersList = new List<Order>();
		private List<Item> menuItemsList = new List<Item>();

		public EmployeeScreen()
		{
			InitializeComponent();

			lv_allOrdersPanel.Columns.Add("Order ID");
			lv_allOrdersPanel.Columns.Add("Customer Name");
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
			lv_allOrdersPanel.Clear();
			lv_allOrdersPanel.Columns.Add("Order ID");
			lv_allOrdersPanel.Columns.Add("Customer Name");
			Utility utility = new Utility();
			ordersList = utility.GetOrdersFromDB();

			lv_allOrdersPanel.View = View.Details;

			for (int i = 0; i < ordersList.Count; i++)
			{
				int oId = ordersList[i].Id;
				int cID = ordersList[i].customer.Id;
				string cName = new Utility().GetCustomerName(cID);


				string[] values = { oId.ToString(), cName };
				var listViewItem = new ListViewItem(values);

				lv_allOrdersPanel.Items.Add(listViewItem);
			}
			lv_allOrdersPanel.Click += new EventHandler(EventForListViewItem);

			//CashierOrderViewItem cashierView = new CashierOrderViewItem();
			//flp_orderView.Controls.Clear();

			////for (int i = 0; i < ordersList.Count; i++)
			////{
			//flp_orderView.Controls.Add(cashierView.DisplayPanel());
			//cashierView.BringToFront();
			//flp_orderView.SendToBack();
			//}


		}

		private void EventForListViewItem(object sender, EventArgs e)
		{
			int clickedIndex = lv_allOrdersPanel.FocusedItem.Index;

			txt_orderIDbox.Text = ordersList[clickedIndex].Id.ToString();
			string name = new Utility().GetCustomerName(ordersList[clickedIndex].customer.Id);
			txt_customerNameBox.Text = name;

			//string query = "SELECT MenuItems.name, MenuItem.price, orders.quantity FROM Orders JOIN MenuItems ON Orders.menuItem = MenuItems.ID WHERE Orders.orderID = '" + ordersList[clickedIndex].Id + "'";
			int orderID = ordersList[clickedIndex].Id;
			List<(string, double, int)> list = new List<(string, double, int)>();
			list = new Utility().GetItemNamePriceQauntity(orderID);


			flp_orderView.Controls.Clear();

			for (int i = 0; i < list.Count; i++)
			{
				CashierOrderViewItem cashierView = new CashierOrderViewItem(list[i].Item1.ToString(), list[i].Item2, list[i].Item3);
				flp_orderView.Controls.Add(cashierView.DisplayPanel());

			}

		}

		private void tab_ViewMenuEmp_Enter(object sender, EventArgs e)
		{
			menuItemsList = new Utility().GetItems();

			List<Button> btnsList = new List<Button>();

			flp_displayMenuEmp.Controls.Clear();
			for (int i = 0; i < menuItemsList.Count; i++)
			{
				Button btn = new Button();
				btn.Text = menuItemsList[i].Name;
				btn.Size = new Size(150, 150);
				btn.Tag = i;
				btnsList.Add(btn);
				btn.Click += new EventHandler(buttonClickedEvent);
				flp_displayMenuEmp.Controls.Add(btn);

			}
		}

		private void buttonClickedEvent(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;
			int clickedButtonIndex = (int)clickedButton.Tag;

			Utility utility = new Utility();
			//string[] names = utility.GetDiscountTaxNames(menuItemsList[clickedButtonIndex].Discount, menuItemsList[clickedButtonIndex].Tax);
			//string[] names = meDAL().GetTaxDiscountNames(menuItemsList[clickedButtonIndex].Discount, menuItemsList[clickedButtonIndex].Tax);


			lbl_itemIdEmp.Text = menuItemsList[clickedButtonIndex].Id.ToString();
			lbl_itemNameEmp.Text = menuItemsList[clickedButtonIndex].Name.ToString();
			lbl_itemPriceEmp.Text = menuItemsList[clickedButtonIndex].Price.ToString();
			lbl_itemDescrEmp.Text = menuItemsList[clickedButtonIndex].Description.ToString();
			lbl_nutriInfoEmp.Text = menuItemsList[clickedButtonIndex].NutritionalInformation.ToString();
			lbl_itemLpPrice.Text = menuItemsList[clickedButtonIndex].LoyaltyPointsPrice.ToString();
			lbl_itemLpReward.Text = menuItemsList[clickedButtonIndex].LoyaltyPointsReward.ToString();
			//lbl_discountEmp.Text = names[0].ToString();
			lbl_discountEmp.Text = null;
			//lbl_taxEmp.Text = names[1].ToString();	
			lbl_taxEmp.Text = null;

		}

		private void btn_orderMgrRefresh_Click(object sender, EventArgs e)
		{
			tab_orderManager.Refresh();
			tab_orderManager.Update();
		}
	}
}
