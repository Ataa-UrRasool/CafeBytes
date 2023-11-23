using DbProject.BusinessLogicLayer.Models;
using DbProject.DbContextLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer
{
	internal class UserCreation
	{
		public void CreateEmployee(Employee employee)
		{
			DAL dAL = new DAL();
			
			dAL.Insert(employee.CreateInsertCredentialsQuery());
			
			employee.CredentialID = dAL.ExecuteGetCount(employee.CreateIDCountQuery());

			int x = dAL.Insert(employee.CreateInsertQuery());
			if(x > 0)
			{
				MessageBox.Show("Employee created...");
			}
			else
			{
				MessageBox.Show("Error while creating the employee...");
			}

		}

		public void CreateCustomer(Customer customer)
		{
			DAL dAL = new DAL();
			dAL.Insert(customer.CreateInsertQuery());


		}
	}
}
