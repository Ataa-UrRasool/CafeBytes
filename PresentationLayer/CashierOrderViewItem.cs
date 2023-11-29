using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.PresentationLayer
{
	public class CashierOrderViewItem : Control
	{
		Label itemName { get; set; }
		Label itemPrice { get; set; }
		TextBox itemQuantity { get; set; }
		Panel panel { get; set; }

		string iName = string.Empty;
		string iPrice = string.Empty;
		string iQuantity = string.Empty;

		public CashierOrderViewItem()
		{
			itemName = new Label();
			itemName.Text = "itemName";
			itemName.Size = new Size(150, 50);


			itemPrice = new Label();
			itemPrice.Text = "itemPrice";
			itemPrice.Size = new Size(150, 50);

			itemQuantity = new TextBox();
			itemQuantity.Text = "itemQuantity";
			itemQuantity.Size = new Size(150, 50);

		}

		public CashierOrderViewItem(string pName, double pPrice, int pQuantity)
		{
			itemName = new Label();
			itemName.Text = "itemName";
			itemName.Size = new Size(150, 50);


			itemPrice = new Label();
			itemPrice.Text = "itemPrice";
			itemPrice.Size = new Size(150, 50);

			itemQuantity = new TextBox();
			itemQuantity.Text = "itemQuantity";
			itemQuantity.Size = new Size(150, 50);
			

			this.iName = pName;
			this.iPrice = pPrice.ToString();
			this.iQuantity = pQuantity.ToString();
		}

		public Panel DisplayPanel()
		{
			panel = new Panel();
			panel.BackColor = Color.White;
			panel.Width = 480;
			panel.Height = 50;

			itemName.Text = iName;
			itemPrice.Text = iPrice;
			itemQuantity.Text = iQuantity;

			itemName.Location = new Point(0, 25);
			itemPrice.Location = new Point(150, 25);
			itemQuantity.Location = new Point(300, 25);

			panel.Controls.Add(itemName);
			panel.Controls.Add(itemPrice);
			panel.Controls.Add(itemQuantity);




			return panel;

		}

	}
}
