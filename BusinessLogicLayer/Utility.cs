using DbProject.DbContextLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer
{
	internal class Utility
	{

		public bool UsernameExists(string username)
		{
			DAL dAL = new DAL();
			int count = dAL.ExecuteGetCount(query(username));
			if (count > 0) 
			{
				return true;	
			}
			else
			{
				return false;
			}
		}
		public string query(string username)
		{
			return "SELECT COUNT(ID) FROM Credentials WHERE username = '" + username + "';";
		}
	}
}
