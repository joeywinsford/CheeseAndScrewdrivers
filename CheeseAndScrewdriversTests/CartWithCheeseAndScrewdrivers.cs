using CheeseAndScrewdriversCSharp02;
using Xunit;

namespace CheeseAndScrewdriversTests
{
	public class CartWithCheeseAndScrewdrivers
	{
		[Fact]
		public void CartWithCheeseAndScrewdriver_TotalIsSumOfBothItemsSalePrices()
		{
			var cheese = new Cheese(4.99m);
			var driver = new Screwdriver(25.0m);

			var cart = new ShoppingCart(new ICartItem[] { driver, cheese });

			Assert.Equal(cheese.SalePrice + driver.SalePrice, cart.SaleTotal);
		}
	}
}
