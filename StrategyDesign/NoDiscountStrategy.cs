using System;
namespace StrategyDesign
{
    public class NoDiscountStrategy : IOfferStrategy
    {
        public NoDiscountStrategy()
        {
        }

        public string Name { get => nameof(NoDiscountStrategy); set => throw new NotImplementedException(); }

        public decimal CalculateDiscount(decimal price)
        {
            return 0;
        }
    }
}
