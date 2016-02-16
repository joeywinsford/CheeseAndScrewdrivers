namespace CheeseAndScrewdriversCSharp02
{
	public class Cheese : ICartItem
	{
		private readonly ExpiredDiscount _expiredDiscount;
		private readonly decimal _salePrice;

		public Cheese(decimal salePrice, ExpiredDiscount expiredDiscount = null)
		{
			_expiredDiscount = expiredDiscount;
			_salePrice = salePrice;
		}

		public decimal SalePrice
		{
			get
			{
				if (_expiredDiscount != null && _expiredDiscount.IsApplied())
					return _salePrice*_expiredDiscount.Discount;
				return _salePrice;
			}
		}
	}
}