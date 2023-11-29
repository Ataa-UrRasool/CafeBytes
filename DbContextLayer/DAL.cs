using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

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

		public string[] GetTaxDiscountNames(string query)
		{

			sqlConnection = new SqlConnection(connectionString);
			sqlCommand = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();

			string[] names = new string[2];


			DataTable dataTable = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
				{
					adapter.Fill(dataTable);
				}
			}

			foreach (DataRow row in dataTable.Rows)
			{
				string value1 = row.IsNull(0) ? null : row[0].ToString();
				string value2 = row.IsNull(1) ? null : row[1].ToString();

				names[0] = value1;
				names[1] = value2;

			}


			return names;
		}
	}
}
