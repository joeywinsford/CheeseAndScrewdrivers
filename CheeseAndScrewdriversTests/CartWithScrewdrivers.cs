using CheeseAndScrewdriversCSharp02;
using Xunit;

namespace CheeseAndScrewdriversTests
{
	public class CartWithScrewdrivers
	{
		[Fact]
		public void CartWithOneScrewdriver_TotalIsSalePriceOfScrewdriver()
		{
			const decimal salePrice = 25.0m;
			var screwdriver = new Screwdriver(salePrice);
			var cart = new ShoppingCart(new [] { screwdriver });

			Assert.Equal(salePrice, cart.SaleTotal);
		}

		[Fact]
		public void CartWithMultipleScrewdrivers_TotalIsSumOfScrewdriverSalePrices()
		{
			var cheapDriver = new Screwdriver(5.0m);
			var expensiveDriver = new Screwdriver(50.0m);

			var cart = new ShoppingCart(new[] { cheapDriver, expensiveDriver });

			Assert.Equal(cheapDriver.SalePrice + expensiveDriver.SalePrice, cart.SaleTotal);
		}
	}
}
