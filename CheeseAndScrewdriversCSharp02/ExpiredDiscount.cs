using System;

namespace CheeseAndScrewdriversCSharp02
{
	public class ExpiredDiscount
	{
		public ExpiredDiscount(decimal discount, DateTime expiryDate)
		{
			Discount = discount;
		}

		public decimal Discount { get; }
	}
}