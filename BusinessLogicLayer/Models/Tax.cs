using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer.Models
{
	internal class Tax
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float Value { get; set; }
		public int Status { get; set; }

		public Tax() 
		{
			Status = 1;
		}

		public string TaxInsertQuery()
		{
			return "INSERT INTO Taxes (name, value, status) VALUES ( '" + Name + "' , '" + Value + "', '" + Status + "' )";
		}
	}
}
