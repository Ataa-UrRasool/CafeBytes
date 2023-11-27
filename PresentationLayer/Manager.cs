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
	public partial class Manager : Form
	{
		List<Item> menuItemsList = new List<Item>();
		public Manager()
		{
			InitializeComponent();
		}

		private void btn_createProfile_Click(object sender, EventArgs e)
		{
			if (new Utility().UsernameExists(txt_username.Text))
			{
				MessageBox.Show("Username already exists.");
				txt_username.Clear();
			}
			else
			{
				BusinessLogicLayer.Models.Employee employee = new BusinessLogicLayer.Models.Employee
				{
					Name = txt_name.Text,
					Email = txt_email.Text,
					PhoneNumber = txt_phoneNo.Text,
					Gender = cmb_gender.Text,
					Address = txt_address.Text,
					HourlyRate = float.Parse(txt_hourlyRate.Text),

					Username = txt_username.Text,
					Password = txt_password.Text
				};

				UserCreation userCreation = new UserCreation();
				userCreation.CreateEmployee(employee);
			}
		}

		private void btn_addItem_Click(object sender, EventArgs e)
		{
			Item item = new Item
			{
				Name = txt_itemName.Text,
				Description = txt_itemDescription.Text,
				NutritionalInformation = txt_itemNutritionalInfo.Text,
				LoyaltyPointsReward = int.Parse(txt_itemLoyaltyPointsReward.Text),
				LoyaltyPointsPrice = int.Parse(txt_itemLoyaltyPointsPrice.Text),
				Price = float.Parse(txt_itemPrice.Text),
				Tax = cmb_taxInfo.SelectedIndex + 1,
				Discount = cmb_discountInfo.SelectedIndex + 1,
			};
			MenuCreation menuCreation = new MenuCreation();
			menuCreation.AddMenuItem(item);
		}

		private void btn_addDiscount_Click(object sender, EventArgs e)
		{
			Discount discount = new Discount
			{
				Name = txt_discountName.Text,
				Value = float.Parse(txt_dicountValue.Text)
			};
			if (cmb_discountStatus.SelectedItem != null)
			{
				if (cmb_discountStatus.SelectedIndex == 0)
				{
					discount.Status = 1; //Active
				}
				else
				{
					discount.Status = 2; //Inactive
				}
			}

			RulesCreation rulesCreation = new RulesCreation();
			rulesCreation.CreateDiscountRule(discount);
		}

		private void btn_addTax_Click(object sender, EventArgs e)
		{
			Tax tax = new Tax
			{
				Name = txt_taxName.Text,
				Value = float.Parse(txt_taxValue.Text)
			};
			if (cmb_taxStatus.SelectedItem != null)
			{
				if (cmb_taxStatus.SelectedIndex == 0)
				{
					tax.Status = 1; //Active
				}
				else
				{
					tax.Status = 2; //Inactive
				}
			}

			RulesCreation rulesCreation = new RulesCreation();
			rulesCreation.CreateTaxRule(tax);
		}


		private void cmb_discountInfo_Click(object sender, EventArgs e)
		{
			cmb_discountInfo.Items.Clear();
			Utility utility = new Utility();
			List<Discount> list = utility.GetDiscounts();
			for (int i = 0; i < list.Count; i++)
			{
				cmb_discountInfo.Items.Add(list[i].Name);
			}
		}

		private void cmb_taxInfo_Click(object sender, EventArgs e)
		{
			cmb_taxInfo.Items.Clear();
			Utility utility = new Utility();
			List<Tax> list = utility.GetTaxes();
			for (int i = 0; i < list.Count; i++)
			{
				cmb_taxInfo.Items.Add(list[i].Name);
			}
		}


		private void DisplayMenuItemsForUpdation()
		{
			Utility utility = new Utility();
			menuItemsList = utility.GetItems();
			List<Button> btnsList = new List<Button>();

			flp_menuDisplayUpdateMenu.Controls.Clear();
			for (int i = 0; i < menuItemsList.Count; i++)
			{
				Button btn = new Button();
				btn.Text = menuItemsList[i].Name;
				btn.Size = new Size(150, 150);

				btn.Tag = i;

				btnsList.Add(btn);
				btn.Click += new EventHandler(buttonClickedEvent);
				flp_menuDisplayUpdateMenu.Controls.Add(btn);
			}

		}

		private void buttonClickedEvent(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;
			int clickedButtonIndex = (int)clickedButton.Tag;

			List<Discount> discounts = new Utility().GetDiscounts();
			List<Tax> taxes = new Utility().GetTaxes();

			txt_menuUpdateID.Text = menuItemsList[clickedButtonIndex].Id.ToString();
			txt_menuUpdateName.Text = menuItemsList[clickedButtonIndex].Name.ToString();
			txt_menuUpdatePrice.Text = menuItemsList[clickedButtonIndex].Price.ToString();
			txt_menuUpdateDescrip.Text = menuItemsList[clickedButtonIndex].Description.ToString();
			txt_menuUpdateNutriInfo.Text = menuItemsList[clickedButtonIndex].NutritionalInformation.ToString();
			txt_menuUpdateLpPrice.Text = menuItemsList[clickedButtonIndex].LoyaltyPointsPrice.ToString();
			txt_menuUpdateLpReward.Text = menuItemsList[clickedButtonIndex].LoyaltyPointsReward.ToString();
			cmb_menuUpdateDiscountInfo.Items.Clear();
			for (int i = 0; i < discounts.Count; i++)
			{
				cmb_menuUpdateDiscountInfo.Items.Add(discounts[i].Name);
			}
			cmb_menuUpdateTaxInfo.Items.Clear();
			for (int i = 0; i < taxes.Count; i++)
			{
				cmb_menuUpdateTaxInfo.Items.Add(taxes[i].Name);
			}

		}

		private void btn_menuUpdate_update_Click(object sender, EventArgs e)
		{
			string newID = txt_menuUpdateID.Text;
			string newName = txt_menuUpdateName.Text;
			string newDesc = txt_menuUpdateDescrip.Text;
			string newPrice = txt_menuUpdatePrice.Text;
			string newNutriInfo = txt_menuUpdateNutriInfo.Text;
			string newLpPrice = txt_menuUpdateLpPrice.Text;
			string newLpReward = txt_menuUpdateLpReward.Text;
			int newDiscount = cmb_menuUpdateDiscountInfo.SelectedIndex;
			newDiscount += 1;
			string strNewDiscount = newDiscount.ToString();
			int newTax = cmb_menuUpdateTaxInfo.SelectedIndex;
			newTax += 1;
			string strNewTax = newTax.ToString();

			if (string.IsNullOrWhiteSpace(newID) || string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newDesc) || string.IsNullOrWhiteSpace(newPrice) || string.IsNullOrWhiteSpace(newNutriInfo)
				|| string.IsNullOrWhiteSpace(newLpPrice) || string.IsNullOrWhiteSpace(newLpReward) || string.IsNullOrWhiteSpace(strNewDiscount) || string.IsNullOrWhiteSpace(strNewTax))
			{
				MessageBox.Show("Input fields cannot be empty.");
				return;

			}
			else
			{
				Utility utility = new Utility();
				DAL dal = new DAL();
				int x = dal.Insert(utility.UpdateMenuItems(int.Parse(newID), newName, newPrice, newNutriInfo, newDesc, newLpPrice, newLpReward, strNewDiscount, strNewTax));
				if (x > 0)
				{
					MessageBox.Show("Item Updated.");
					DisplayMenuItemsForUpdation();
				}
				else
				{
					MessageBox.Show("Error while updating the item.");
				}
			}

		}


		private void tab_updateMenuItems_Enter(object sender, EventArgs e)
		{
			DisplayMenuItemsForUpdation();
		}


	}

}
