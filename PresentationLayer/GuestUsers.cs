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
            //Button bu = new Button();
            //Controls.Add(bu)
            PopulateMenuPanel();
        }

        public void PopulateMenuPanel()
        {
            const int buttonHeight = 150;
            const int buttonWidth = 150;
            const int spaceBetweenButtons = 20;

            int panelHeight = pnl_MenuItems.Height;
            int panelWidth = pnl_MenuItems.Width;

            List<Button> menuItemButtons = new List<Button>();
            List<Item> menuItems = new Utility().GetItems();

            int maxButtonsInRow = (panelWidth - (buttonWidth + spaceBetweenButtons)) / (buttonWidth + (spaceBetweenButtons * 2));

            for (int i = 0; i < menuItems.Count; i++)
            {
                Button menuItemButton = new Button();
                menuItemButton.Text = menuItems[i].Name;

                menuItemButtons.Add(menuItemButton);
            }

            for
            
        }
    }
}