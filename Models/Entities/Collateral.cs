﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollateralManagement.Models.Entities
{
    public class Collateral
    {
		public int Id { get; set; }
		public int LoanId { get; set; }
		public int CustomerId { get; set; }
		public string Type { get; set; }

		//Grams for Gold
		//sq.feet for Land
		//sq.feet for home or real estate
		public int unitValue { get; set; }
		public int NoOfUnits { get; set; }
		public DateTime InitialAssesDate { get; set; }
		
	}
}
