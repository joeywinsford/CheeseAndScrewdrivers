namespace CheeseAndScrewdriversCSharp02
{
	public class ShoppingCart
	{
		private readonly Screwdriver _screwdriver;

		public ShoppingCart(Screwdriver screwdriver = null)
		{
			_screwdriver = screwdriver;
		}

		public decimal SaleTotal => _screwdriver?.SalePrice ?? 0.0m;
	}
}