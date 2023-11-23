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
			BusinessLogicLayer.Models.Employee employee = new BusinessLogicLayer.Models.Employee();
			employee.Name = txt_name.Text;
			employee.Email = txt_email.Text;
			employee.PhoneNumber = txt_phoneNo.Text;
			employee.Gender = cmb_gender.Text;
			employee.Address = txt_address.Text;
			employee.HourlyRate = float.Parse(txt_hourlyRate.Text);
			
			employee.Username = txt_username.Text;
			employee.Password = txt_password.Text;

			UserCreation userCreation = new UserCreation();
			userCreation.CreateEmployee(employee);
		}

	}
}
