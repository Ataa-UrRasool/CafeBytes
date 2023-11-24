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
	public partial class Manager : Form
	{
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

	}

}
