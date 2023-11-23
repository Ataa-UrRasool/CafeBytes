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
			Employee employee = new Employee();
			employee.Name = txt_name.Text;
			employee.Email = txt_email.Text;
			employee.PhoneNumber = txt_phoneNo.Text;
		
			UserCreation userCreation = new UserCreation();	
			userCreation.CreateEmployee(employee);
		}


	}
}
