namespace CheeseAndScrewdriversCSharp02
{
	public class Bundle : ICartItem
	{
		private readonly Cheese _cheese;
		private readonly Screwdriver _screwdriver;
		private readonly PercentageDiscount _percentageDiscount;

		public Bundle(Cheese cheese, Screwdriver screwdriver, PercentageDiscount percentageDiscount)
		{
			_cheese = cheese;
			_screwdriver = screwdriver;
			_percentageDiscount = percentageDiscount;
		}

		public decimal SalePrice => (_cheese.SalePrice + _screwdriver.SalePrice) * _percentageDiscount.Discount;
	}
}