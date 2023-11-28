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
		public int ID { get; set; }	
		public float HourlyRate { get; set; }
		public string Role { get; set; }

		public int CredentialID { get; set; }

		public List<Schedule> EmployeeSchedule { get; set; }

		public string CreateInsertCredentialsQuery()
		{
			return "INSERT INTO Credentials (username, password) VALUES ('" + Username + "', '" + Password + "')";
		}

		public string CreateInsertQuery()
		{
			if (Gender.ToUpper() == Constants.GENDER_MALE)
			{
				return "INSERT INTO Employees (name, phoneNo, email, address, hourlyRate, gender, credential, role)" +
				" VALUES ('" + Name + "', '" + PhoneNumber + "', '" + Email + "', '" + Address + "', '" + HourlyRate + "', 1 ,'" + CredentialID + "', 2);";
			}
			else
			{
				return "INSERT INTO Employees (name, phoneNo, email, address, hourlyRate, gender, credential, role)" +
				" VALUES ('" + Name + "', '" + PhoneNumber + "', '" + Email + "', '" + Address + "', '" + HourlyRate + "', 2 ,'" + CredentialID + "', 2);";
			}

		}

		public string CreateIDCountQuery()
		{
			return "SELECT TOP 1 * FROM Credentials ORDER BY Credentials.ID DESC";
		}
	}
}
