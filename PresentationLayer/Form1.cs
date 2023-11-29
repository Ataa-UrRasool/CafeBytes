using DbProject.BusinessLogicLayer;
using DbProject.PresentationLayer;

namespace DbProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void signInBtn_Click(object sender, EventArgs e)
		{
			if (usernameBox.Text == String.Empty || passwordBox.Text == String.Empty)
			{
				MessageBox.Show("Incomplete form");

				return;
			}
			else
			{
				Authentication authentication = new Authentication();
				string role = authentication.Authenticate(this.usernameBox.Text, this.passwordBox.Text);

				if (role == Constants.ROLE_MANAGER)
				{
					ManagerScreen manager = new ManagerScreen();
					manager.Visible = true;
					this.Visible = false;
					
					//Constants.USER_NAME = 
				}
				else if (role == Constants.ROLE_EMPLOYEES)
				{
					EmployeeScreen customerByEmployee = new EmployeeScreen();
					customerByEmployee.Visible = true;
					this.Visible = false;
				}
				else
				{
					MessageBox.Show("Bug Off");
				}

			}


		}

		private void lbl_guestScreen_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			GuestUsersScreen guestUsers = new GuestUsersScreen();
			guestUsers.Visible = true;
		}


	}
}
