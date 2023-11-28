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

		private string connectionString = "Server=VICTUS91\\SQLEXPRESS;Database=CafeBytes;Trusted_Connection=True;";
		SqlConnection sqlConnection;
		SqlCommand sqlCommand;

		public DAL() { }

		public DataTable executeGetData(string query)
		{
			sqlConnection = new SqlConnection(connectionString);
			sqlCommand = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();

			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable();
			sqlDataAdapter.Fill(dt);


		sqlConnection.Close();
			sqlDataAdapter.Dispose();
			return dt;
		}

		public int Insert(string query)
		{
			sqlConnection = new SqlConnection(connectionString);
			sqlCommand = new SqlCommand(query, sqlConnection);

			sqlConnection.Open();
			int a = sqlCommand.ExecuteNonQuery();

			return a;
		}

		public int ExecuteGetCount(string query)
		{
			sqlConnection = new SqlConnection(connectionString);
			sqlCommand = new SqlCommand(query, sqlConnection);

			sqlConnection.Open();
			int n = (int)sqlCommand.ExecuteScalar();
			return n;
		}
	}
}
