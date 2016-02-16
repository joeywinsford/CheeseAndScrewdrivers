using CheeseAndScrewdriversCSharp02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
