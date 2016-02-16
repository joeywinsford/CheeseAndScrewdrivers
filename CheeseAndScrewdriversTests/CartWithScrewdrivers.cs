using CheeseAndScrewdriversCSharp02;
using Xunit;

namespace CheeseAndScrewdriversTests
{
	public class CartWithScrewdrivers
	{
		[Fact]
		public void TotalIsSumOfScrewdriverSalePrices()
		{
			var screwdriver = new Screwdriver(25.0m);

			var cart = new ShoppingCart(screwdriver);

			Assert.Equal(25.0m, cart.SaleTotal);
		}
	}
}
