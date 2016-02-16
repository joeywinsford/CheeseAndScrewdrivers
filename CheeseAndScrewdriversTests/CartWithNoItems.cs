using CheeseAndScrewdriversCSharp02;
using Xunit;

namespace CheeseAndScrewdriversTests
{
	public class CartWithNoItems
	{
		[Fact]
		public void HasZeroTotal()
		{
			var cart = new ShoppingCart();
			Assert.Equal(0.0m, cart.SaleTotal);
		}
	}
}
