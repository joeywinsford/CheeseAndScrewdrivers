using System.Linq;

namespace CheeseAndScrewdriversCSharp02
{
	public class ShoppingCart
	{
		private readonly ICartItem[] _screwdrivers;

		public ShoppingCart() : this(new ICartItem[0])
		{
		}

		public ShoppingCart(ICartItem[] screwdrivers)
		{
			_screwdrivers = screwdrivers;
		}

		public decimal SaleTotal => _screwdrivers?.Sum(s => s.SalePrice) ?? 0.0m;
	}
}