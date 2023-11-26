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

namespace DbProject.PresentationLayer
{
	public partial class GuestUsers : Form
	{
		public GuestUsers()
		{
			InitializeComponent();

			PopulateMenuPanel();
		}

		public void PopulateMenuPanel()
		{
			const int buttonHeight = 150;
			const int buttonWidth = 150;

			const int xOffset = 25;
			const int yOffset = 25;

			int panelHeight = pnl_MenuItems.Height;
			int panelWidth = pnl_MenuItems.Width;

			int maxButtonsInRow = (panelWidth - (buttonWidth + xOffset)) / (buttonWidth + xOffset);

			List<Button> buttons = new List<Button>();
			List<Item> itemsList = new Utility().GetItems();

			for (int i = 0; i < itemsList.Count; i++)
			{
				Button button = new Button();

				button.Text = "Name: " + itemsList[i].Name + "\n\nPrice: " + itemsList[i].Price;
				button.Size = new Size(buttonWidth, buttonHeight);

				pnl_MenuItems.Controls.Add(button);
				buttons.Add(button);
			}

			int numRows = 0;

			if (buttons.Count % maxButtonsInRow == 0)
			{
				numRows = buttons.Count / maxButtonsInRow;
			}
			else
			{
				numRows = (buttons.Count / maxButtonsInRow) + 1;

			}

			int horizontalOffset = xOffset;
			int verticalOffset = yOffset + buttonHeight;

			int counter = 0;

			for (int i = 0; i < numRows; i++)
			{
				horizontalOffset = xOffset;

				for (int j = 0; j < maxButtonsInRow; j++)
				{
					if (counter == buttons.Count)
					{
						break;
					}

					if (i == 0 && j == 0)
					{
						buttons[counter].Location = new Point(horizontalOffset, 0);
						horizontalOffset += buttonWidth + xOffset;

						counter++;
					}
					else if (i == 0 && j > 0)
					{
						buttons[counter].Location = new Point(horizontalOffset, 0);
						horizontalOffset += buttonWidth + xOffset;

						counter++;
					}
					else if (i > 0 && j == 0)
					{
						if (i > 1)
						{
							verticalOffset += buttonHeight + yOffset;
						}

						buttons[counter].Location = new Point(horizontalOffset, verticalOffset);
						horizontalOffset += buttonWidth + xOffset;

						counter++;
					}
					else if (i > 0 && j > 0)
					{
						buttons[counter].Location = new Point(horizontalOffset, verticalOffset);
						horizontalOffset += buttonWidth + xOffset;

						counter++;
					}
				}
			}
		}

	}
}