using DbProject.BusinessLogicLayer;

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
			if (role == "msnsger")
			{

			}
			else if (csdhirt)
			{
				//incorrect
			}
			else { error}
		}
	}
}
