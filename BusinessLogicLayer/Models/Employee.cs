using DbProject.DbContextLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer.Models
{
	internal class Employee : Person
	{
		public float HourlyRate { get; set; }
		public string Role { get; set; }

		public List<Schedule> EmployeeSchedule { get; set; }

		public Employee() { Id = GetIDCount() + 1; }

		public int GetIDCount()
		{
			int count = new DAL().executeGetData(CreateIDCountQuery());
			return count;
		}

		public string CreateInsertQuery()
		{
			string query = "INSERT INTO Employees (ID, name, ) VALUES ('" + Id + "')";

			return query;
		}

		public string CreateIDCountQuery()
		{
			string query = "SELECT COUNT(*) FROM Employees";
			return query;
		}
	}
}
