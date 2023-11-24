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
			Authentication authentication = new Authentication();
			string role = authentication.Authenticate(this.usernameBox.Text, this.passwordBox.Text);

			if (role == Constants.ROLE_MANAGER)
			{
				Manager manager = new Manager();
				manager.Visible = true;
				this.Visible = false;

			}
			else if (role == Constants.ROLE_EMPLOYEES)
			{
				Employee customerByEmployee = new Employee();
				customerByEmployee.Visible = true;
				this.Visible = false;
			}
			else
			{
				MessageBox.Show("Fuck oFF");
			}

		}

		private void lbl_guestScreen_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			GuestUsers guestUsers = new GuestUsers();
			guestUsers.Visible = true;
		}
	}
}
