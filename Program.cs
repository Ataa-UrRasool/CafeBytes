using DbProject.PresentationLayer;

namespace DbProject
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			//Application.Run(new Form1());
			Application.Run(new EmployeeScreen());
			//Application.Run(new ManagerScreen());
			//Application.Run(new GuestUsersScreen());	
		}
	}
}