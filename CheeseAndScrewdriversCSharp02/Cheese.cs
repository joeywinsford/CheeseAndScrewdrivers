namespace CheeseAndScrewdriversCSharp02
{
	public class Cheese : ICartItem
	{
		public Cheese(decimal salePrice)
		{
			SalePrice = salePrice;
		}

		public decimal SalePrice { get; }
	}
}