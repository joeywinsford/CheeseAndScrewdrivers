using CheeseAndScrewdriversCSharp02;
using Xunit;

namespace CheeseAndScrewdriversTests
{
	public class CartWithBundle
	{
		[Fact]
		public void TotalDiscountsForBundle()
		{
			var cheese = new Cheese(4.5m);
			var screwdriver = new Screwdriver(25.0m);
			var bundle = new Bundle(cheese, screwdriver, new PercentageDiscount(0.1m));

			var cart = new ShoppingCart(new ICartItem[] { bundle });

			Assert.Equal((cheese.SalePrice + screwdriver.SalePrice) * 0.1m, cart.SaleTotal);
		}
	}
}
