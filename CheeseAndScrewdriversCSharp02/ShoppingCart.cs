using System.Linq;

namespace CheeseAndScrewdriversCSharp02
{
	public class ShoppingCart
	{
		private readonly Screwdriver[] _screwdrivers;

		public ShoppingCart() : this(new Screwdriver[0])
		{
		}

		public ShoppingCart(Screwdriver[] screwdrivers)
		{
			_screwdrivers = screwdrivers;
		}

		public decimal SaleTotal => _screwdrivers?.Sum(s => s.SalePrice) ?? 0.0m;
	}
}