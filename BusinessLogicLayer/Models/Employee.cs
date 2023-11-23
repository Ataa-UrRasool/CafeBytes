﻿using DbProject.DbContextLayer;
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
			return "INSERT INTO Employees (name, phoneNo, email, address, hourlyRate)" +
				" VALUES ('" + Name + "', '" + PhoneNumber + "', '" + Email + "', '" + Address + "', '" + HourlyRate + "')";
		}

		public string CreateIDCountQuery()
		{
			string query = "SELECT COUNT(*) FROM Employees";
			return query;
		}
	}
}
