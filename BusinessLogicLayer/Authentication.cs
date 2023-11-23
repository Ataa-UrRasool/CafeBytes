using DbProject.DbContextLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer
{
	internal class Authentication
	{
		public string Authenticate(string username, string password)
		{
			DAL dAL = new DAL();
			DataTable dt = dAL.executeGetData(CreateGetCredentialsQuery(username));
			int id = dt.Rows[0].Field<int>("ID");
			string pass = dt.Rows[0].Field<string>("password");

			if (password == pass)
			{
				//MessageBox.Show("Password Found!");
				dt = dAL.executeGetData(CreateGetRoleFromCredentialsQuery(id));
				if (dt.Rows[0].Field<string>("role") == Constants.ROLE_MANAGER)
				{

					return Constants.ROLE_MANAGER;
				}	
				else
				{
					//
					return Constants.ROLE_CASHIER;

				}
			}
			else
			{
				return Constants.NO_MATCH;
			}
		}

		private string CreateGetRoleFromCredentialsQuery(int credentialID)
		{
			return "SELECT role FROM Roles INNER JOIN Employees ON Employees.role = Roles.ID WHERE Employees.credential = '" + credentialID + "';";
		}

		private string CreateGetCredentialsQuery(string username)
		{
			return "SELECT ID, password FROM Credentials WHERE username = '" + username + "'";
		}
	}
}
