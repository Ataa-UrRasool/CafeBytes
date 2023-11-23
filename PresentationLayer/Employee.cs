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
	public partial class Employee : Form
	{
		public Employee()
		{
			InitializeComponent();
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
	}
}
