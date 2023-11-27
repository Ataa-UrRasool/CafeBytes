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
	public partial class GuestUsers : Form
	{
		private List<Item> itemsList;
		List<System.Windows.Forms.Button> MenuItemButtons;
		Order CustomerOrder;

		public GuestUsers()
		{
			InitializeComponent();

			PopulateMenuPanel();

			CustomerOrder = new Order();
			CustomerOrder.ItemsList = new List<Item>();
			CustomerOrder.Quantity = new List<int>();

			lv_guestUser.Columns.Add("Name");
			lv_guestUser.Columns.Add("Price");
			lv_guestUser.Columns.Add("Quantity");
		}

		public void PopulateMenuPanel()
		{
			const int buttonHeight = 150;
			const int buttonWidth = 150;

			const int verticalSpacing = 25;
			const int horizontalSpacing = 25;

			int panelHeight = pnl_MenuItems.Height;
			int panelWidth = pnl_MenuItems.Width;

			//Some magic formula only God knows how I came up with.
			int maxButtonsInRow = (panelWidth - (buttonWidth + horizontalSpacing)) / (buttonWidth + horizontalSpacing);

			MenuItemButtons = new List<System.Windows.Forms.Button>();
			itemsList = new Utility().GetItems();

			for (int i = 0; i < itemsList.Count; i++)
			{
				System.Windows.Forms.Button MenuItemButton = new System.Windows.Forms.Button();

				MenuItemButton.Size = new Size(buttonWidth, buttonHeight);
				MenuItemButton.Text = "Name: " + itemsList[i].Name + "\n\nPrice: " + itemsList[i].Price;
				MenuItemButton.Click += new EventHandler(buttonClickedEvent);

				pnl_MenuItems.Controls.Add(MenuItemButton);
				MenuItemButtons.Add(MenuItemButton);

				MenuItemButton.Tag = i;
			}

			int numRows = 0;
			if (MenuItemButtons.Count % maxButtonsInRow == 0)
			{
				numRows = MenuItemButtons.Count / maxButtonsInRow;
			}
			else
			{
				numRows = (MenuItemButtons.Count / maxButtonsInRow) + 1;
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
					if (numberOfButtonsPopulated == MenuItemButtons.Count)
					{
						break;
					}

					if (i == 0 && j == 0)
					{
						MenuItemButtons[numberOfButtonsPopulated].Location = new Point(horizontalOffset, 0);
						horizontalOffset += buttonWidth + horizontalSpacing;

						numberOfButtonsPopulated++;
					}
					else if (i == 0 && j > 0)
					{
						MenuItemButtons[numberOfButtonsPopulated].Location = new Point(horizontalOffset, 0);
						horizontalOffset += buttonWidth + horizontalSpacing;

						numberOfButtonsPopulated++;
					}
					else if (i > 0 && j == 0)
					{
						if (i > 1)
						{
							verticalOffset += buttonHeight + verticalSpacing;
						}

						MenuItemButtons[numberOfButtonsPopulated].Location = new Point(horizontalOffset, verticalOffset);
						horizontalOffset += buttonWidth + horizontalSpacing;

						numberOfButtonsPopulated++;
					}
					else if (i > 0 && j > 0)
					{
						MenuItemButtons[numberOfButtonsPopulated].Location = new Point(horizontalOffset, verticalOffset);
						horizontalOffset += buttonWidth + horizontalSpacing;

						numberOfButtonsPopulated++;
					}
				}
			}
		}

		private void buttonClickedEvent(object sender, EventArgs e)
		{
			System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
			int clickedButtonIndex = (int)clickedButton.Tag;

			CustomerOrder.ItemsList.Add(itemsList[clickedButtonIndex]);
			CustomerOrder.Quantity.Add(1);

			string[] orderDetails = { CustomerOrder.ItemsList.Last().Name.ToString(), CustomerOrder.ItemsList.Last().Price.ToString(), CustomerOrder.Quantity.Last().ToString() };

			var listViewItem = new ListViewItem(orderDetails);
			lv_guestUser.View = View.Details;

			if (lv_guestUser.Items.Count == 0)
			{
				lv_guestUser.Items.Add(listViewItem);
			}
			else
			{
				bool inserted = false;
				for (int i = 0; i < lv_guestUser.Items.Count; i++)
				{
					if (lv_guestUser.Items[i].Text == itemsList[clickedButtonIndex].Name)
					{
						ListViewItem myItem = lv_guestUser.Items[i];
						string[] mySubItems = { myItem.SubItems[0].Text, myItem.SubItems[1].Text, myItem.SubItems[2].Text };

						int quantity = int.Parse(mySubItems[2]);

						quantity++;
						mySubItems[2] = quantity.ToString();

						lv_guestUser.Items[i].Remove();
						listViewItem = new ListViewItem(mySubItems);
						lv_guestUser.Items.Add(listViewItem);

						inserted = true;
						break;
					}
				}

				if (!inserted)
				{
					lv_guestUser.Items.Add(listViewItem);
				}
			}

		}

		private void btn_placeOrder_Click(object sender, EventArgs e)
		{
			bool validID = new Utility().VerifyID(int.Parse(txt_custoID.Text));

			if (validID)
			{
				CustomerOrder.customer.Id = int.Parse(txt_custoID.Text);
				OrderManagement order = new OrderManagement();
				order.CreateOrder(CustomerOrder);
			}
			else
			{
				CustomerOrder.customer.Id = 0;
				OrderManagement order = new OrderManagement();
				order.CreateOrder(CustomerOrder);

			}
		}
	}
}