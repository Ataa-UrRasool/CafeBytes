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
			//Dataset ans = dAL.executeGet(CreateGetCredentialsQuery(username));
			DataTable dt = dAL.executeGetData(CreateGetCredentialsQuery(username));
			//dt.
			return Constants.ROLE_MANAGER;
		}

		private string CreateGetCredentialsQuery(string username)
		{
			return "SELECT ID, password FROM Credentials WHERE username = '" + username + "'";
		}
	}
}
