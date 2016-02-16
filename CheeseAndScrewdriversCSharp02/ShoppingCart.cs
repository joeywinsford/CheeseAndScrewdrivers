using System.Linq;

namespace CheeseAndScrewdriversCSharp02
{
	public class ShoppingCart
	{
		private readonly ICartItem[] _items;

		public ShoppingCart() : this(new ICartItem[0])
		{
		}

		public ShoppingCart(ICartItem[] items)
		{
			_items = items;
		}

		public decimal SaleTotal => _items?.Sum(s => s.SalePrice) ?? 0.0m;
	}
}