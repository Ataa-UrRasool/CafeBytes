using DbProject.BusinessLogicLayer;
using DbProject.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbProject.PresentationLayer
{
	public partial class GuestUsersScreen : Form
	{
		private List<Item> itemsList;
		List<System.Windows.Forms.Button> menuItemButtons;
		Order customerOrder;
		string[] orderDetails;

		ListViewItem listViewItem;

		List<int> listQuantity = new List<int>();


		public GuestUsersScreen()
		{
			InitializeComponent();

			populateMenuPanel();

			for (int i = 0; i < itemsList.Count; i++)
			{
				listQuantity.Add(0);
			}

			customerOrder = new Order();
			customerOrder.ItemsList = new List<Item>();
			customerOrder.Quantity = new List<int>();

			lv_guestUser.Columns.Add("Name");
			lv_guestUser.Columns.Add("Price");
			lv_guestUser.Columns.Add("Quantity");

			orderDetails = new string[3];
		}

		public void populateMenuPanel()
		{
			const int buttonHeight = 150;
			const int buttonWidth = 150;

			const int verticalSpacing = 25;
			const int horizontalSpacing = 25;

			int panelHeight = pnl_MenuItems.Height;
			int panelWidth = pnl_MenuItems.Width;

			//Some magic formula only God knows how I came up with.
			int maxButtonsInRow = (panelWidth - (buttonWidth + horizontalSpacing)) / (buttonWidth + horizontalSpacing);

			menuItemButtons = new List<System.Windows.Forms.Button>();
			itemsList = new Utility().GetItems();

			for (int i = 0; i < itemsList.Count; i++)
			{
				System.Windows.Forms.Button MenuItemButton = new System.Windows.Forms.Button();

				MenuItemButton.Size = new Size(buttonWidth, buttonHeight);
				MenuItemButton.Text = "Name: " + itemsList[i].Name + "\n\nPrice: " + itemsList[i].Price;
				MenuItemButton.Click += new EventHandler(menuItemButtonClickedEvent);

				pnl_MenuItems.Controls.Add(MenuItemButton);
				menuItemButtons.Add(MenuItemButton);

				MenuItemButton.Tag = i;
			}

			int numRows = 0;
			if (menuItemButtons.Count % maxButtonsInRow == 0)
			{
				numRows = menuItemButtons.Count / maxButtonsInRow;
			}
			else
			{
				numRows = (menuItemButtons.Count / maxButtonsInRow) + 1;
			}

			int horizontalOffset = horizontalSpacing;
			int verticalOffset = verticalSpacing + buttonHeight;

			int numberOfButtonsPopulated = 0;
			for (int i = 0; i < numRows; i++)
			{
				horizontalOffset = horizontalSpacing;

				for (int j = 0; j < maxButtonsInRow; j++)
				{
					//Break if all buttons have been populated. We dont care about if the loops have finished.
					//The loops will always >= number of buttons
					if (numberOfButtonsPopulated == menuItemButtons.Count)
					{
						break;
					}

					if (i == 0 && j == 0)
					{
						menuItemButtons[numberOfButtonsPopulated].Location = new Point(horizontalOffset, 0);
						horizontalOffset += buttonWidth + horizontalSpacing;

						numberOfButtonsPopulated++;
					}
					else if (i == 0 && j > 0)
					{
						menuItemButtons[numberOfButtonsPopulated].Location = new Point(horizontalOffset, 0);
						horizontalOffset += buttonWidth + horizontalSpacing;

						numberOfButtonsPopulated++;
					}
					else if (i > 0 && j == 0)
					{
						if (i > 1)
						{
							verticalOffset += buttonHeight + verticalSpacing;
						}

						menuItemButtons[numberOfButtonsPopulated].Location = new Point(horizontalOffset, verticalOffset);
						horizontalOffset += buttonWidth + horizontalSpacing;

						numberOfButtonsPopulated++;
					}
					else if (i > 0 && j > 0)
					{
						menuItemButtons[numberOfButtonsPopulated].Location = new Point(horizontalOffset, verticalOffset);
						horizontalOffset += buttonWidth + horizontalSpacing;

						numberOfButtonsPopulated++;
					}
				}
			}
		}

		private void menuItemButtonClickedEvent(object sender, EventArgs e)
		{
			System.Windows.Forms.Button chosenButton = (System.Windows.Forms.Button)sender;
			int clickedBtnIndex = (int)chosenButton.Tag;

			string selectedItem = itemsList[clickedBtnIndex].Name.ToString();

			listViewItem = new ListViewItem(orderDetails);

			lv_guestUser.View = View.Details;

			if (customerOrder.ItemsList.Count == 0)
			{
				listQuantity[clickedBtnIndex]++;
				customerOrder.ItemsList.Add(itemsList[clickedBtnIndex]);
				customerOrder.Quantity.Add(listQuantity[clickedBtnIndex]);
			}
			else
			{
				for (int i = 0; i < customerOrder.ItemsList.Count; i++)
				{
					if (customerOrder.ItemsList[i].Name == selectedItem)
					{
						listQuantity[clickedBtnIndex]++;
						customerOrder.Quantity.Add(listQuantity[clickedBtnIndex]);
					}
					else
					{
						customerOrder.ItemsList.Add(itemsList[clickedBtnIndex]);
						listQuantity[clickedBtnIndex]++;
						customerOrder.Quantity.Add(listQuantity[clickedBtnIndex]);
						break;
					}
				}

			}
			orderDetails[0] = customerOrder.ItemsList[clickedBtnIndex].Name;
			orderDetails[1] = customerOrder.ItemsList[clickedBtnIndex].Price.ToString();
			orderDetails[2] = listQuantity[clickedBtnIndex].ToString();
			//orderDetails[2] = customerOrder.Quantity[clickedBtnIndex].ToString();
			lv_guestUser.Items.Add(listViewItem);
		}

		private void btn_placeOrder_Click(object sender, EventArgs e)
		{

			if (!string.IsNullOrWhiteSpace(txt_custoID.Text))
			{
				bool validID = new Utility().VerifyID(int.Parse(txt_custoID.Text));
				if (!validID)
				{
					MessageBox.Show("Invalid ID");
					txt_custoID.Refresh();
				}
				else
				{
					customerOrder.customer.Id = int.Parse(txt_custoID.Text);
					OrderManagement order = new OrderManagement();
					order.CreateOrder(customerOrder);
					MessageBox.Show("Order Placed Successfully");
					Form1 form1 = new Form1();
					form1.Visible = true;
					this.Visible = false;
				}

			}
			else
			{
				customerOrder.customer.Id = 6; //walk in
				OrderManagement order = new OrderManagement();
				order.CreateOrder(customerOrder);
				MessageBox.Show("Order Placed Successfully");
				Form1 form1 = new Form1();
				form1.Visible = true;
				this.Visible = false;
			}
		}

		private void btn_return_Click(object sender, EventArgs e)
		{
			this.Refresh();
			this.Visible = false;
			Form1 form = new Form1();
			form.Visible = true;
		}
	}
}