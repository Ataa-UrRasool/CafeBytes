using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.PresentationLayer
{
	internal class CashierOrderViewItem : Control
	{
		Label itemName { get; set; }
		Label itemPrice { get; set; }
		TextBox itemQuantity { get; set; }
		Panel panel { get; set; }


		public CashierOrderViewItem()
		{
			itemName = new Label();
			itemName.Text = "itemName";
			itemName.Size = new Size(120, 40);


			itemPrice = new Label();
			itemPrice.Text = "itemPrice";
			itemPrice.Size = new Size(120, 40);

			itemQuantity = new TextBox();
			itemQuantity.Text = "itemQuantity";
			itemQuantity.Size = new Size(100, 20);
		}

		public Panel DisplayPanel()
		{
			panel = new Panel();
			panel.ForeColor = Color.White;
			panel.Width = 100;
			panel.Height = 200;

			itemName.Location = new Point(0, 25);
			itemPrice.Location = new Point(125, 25);
			itemQuantity.Location = new Point(150, 25);

			panel.Controls.Add(itemName);
			panel.Controls.Add(itemPrice);
			panel.Controls.Add(itemQuantity);




			return panel;

		}

	}
}
