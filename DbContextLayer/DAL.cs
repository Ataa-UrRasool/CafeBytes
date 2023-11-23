using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.DbContextLayer
{
	internal class DAL
	{

		private string connectionString = "";
		SqlConnection conn;
		SqlCommand cmd;
	
		public DAL()
		{
			conn = new SqlConnection(connectionString);
		}

		public DataTable executeGetData(string query)
		{
			cmd = new SqlCommand(query, conn);
			cmd.ExecuteNonQuery();
			conn.Open();


			DataTable dt = new DataTable();
			dt = cmd.ExecuteReader();

			conn.Close();





			return dt;
		}

		public int executeGetCount(string query)
		{

		}

		public void Insert(string query)
		{

		}
	}
}
