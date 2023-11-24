using DbProject.BusinessLogicLayer.Models;
using DbProject.DbContextLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer
{
	internal class RulesCreation
	{
		public void CreateTaxRule(Tax tax)
		{
			DAL dAL = new DAL();
			int x = dAL.Insert(tax.TaxInsertQuery());

			if (x > 0)
			{
				MessageBox.Show("Tax added in the database");
			}
			else
			{
				MessageBox.Show("Error while adding the Tax...");
			}
		}

		public void CreateDiscountRule(Discount discount) 
		{
			DAL dAL = new DAL();
			int x = dAL.Insert(discount.DiscountInsertQuery());

			if (x > 0)
			{
				MessageBox.Show("Discount added in the database");
			}
			else
			{
				MessageBox.Show("Error while adding the Discount...");
			}
		}
	}
}
