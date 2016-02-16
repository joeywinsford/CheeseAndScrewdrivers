using System;
using CheeseAndScrewdriversCSharp02;
using Xunit;

namespace CheeseAndScrewdriversTests
{
	public class CartWithExpiredCheese
	{
		[Fact]
		public void WhenCheeseIsExpired_TotalIncludesDiscount()
		{
			const decimal salePrice = 4.50m;
			const decimal discount = 0.5m;
			var expiryDate = DateTime.Today.AddDays(-1);
			var expiredCheese = new Cheese(salePrice, new ExpiredDiscount(discount, expiryDate, () => DateTime.Now));

			var cart = new ShoppingCart(new ICartItem[] { expiredCheese });

			Assert.Equal(salePrice * discount, cart.SaleTotal);
		}

		[Fact]
		public void WhenCheeseIsNotExpired_TotalIsFullPriceOfCheese()
		{
			var expiryDate = DateTime.Today.AddDays(1);
			var freshCheese = new Cheese(4.50m, new ExpiredDiscount(0.5m, expiryDate, () => DateTime.Now));

			var cart = new ShoppingCart(new ICartItem[] { freshCheese });

			Assert.Equal(4.50m, cart.SaleTotal);
		}
	}
}
