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

		public string CreateInsertQuery()
		{
			if (Gender.ToUpper() == Constants.GENDER_MALE)
			{
				return "INSERT INTO Employees (name, phoneNo, email, address, hourlyRate, gender)" +
				" VALUES ('" + Name + "', '" + PhoneNumber + "', '" + Email + "', '" + Address + "', '" + HourlyRate + "', 1)";
			}
			else
			{
				return "INSERT INTO Employees (name, phoneNo, email, address, hourlyRate, gender)" +
				" VALUES ('" + Name + "', '" + PhoneNumber + "', '" + Email + "', '" + Address + "', '" + HourlyRate + "', 2)";
			}

		}

		public string CreateIDCountQuery()
		{
			string query = "SELECT COUNT(*) FROM Employees";
			return query;
		}
	}
}
