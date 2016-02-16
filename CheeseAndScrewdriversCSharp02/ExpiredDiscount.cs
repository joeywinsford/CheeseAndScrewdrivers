using System;

namespace CheeseAndScrewdriversCSharp02
{
	public class ExpiredDiscount
	{
		private readonly DateTime _expiryDate;
		private readonly Func<DateTime> _currentDate;

		public ExpiredDiscount(decimal discount, DateTime expiryDate, Func<DateTime> currentDate)
		{
			_expiryDate = expiryDate;
			_currentDate = currentDate;
			Discount = discount;
		}

		public decimal Discount { get; }

		public bool IsApplied()
		{
			return _currentDate() > _expiryDate;
		}
	}
}