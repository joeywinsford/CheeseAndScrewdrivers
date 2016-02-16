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
			var expiredCheese = new Cheese(salePrice, new ExpiredDiscount(discount, expiryDate));

			var cart = new ShoppingCart(new ICartItem[] { expiredCheese });

			Assert.Equal(salePrice * discount, cart.SaleTotal);
		}
	}
}
