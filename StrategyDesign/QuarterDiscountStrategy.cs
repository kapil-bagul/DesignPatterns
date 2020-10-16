using System;
namespace StrategyDesign
{
    public class QuarterDiscountStrategy : IOfferStrategy
    {
        public QuarterDiscountStrategy()
        {
        }

        public string Name { get => nameof(QuarterDiscountStrategy); set => throw new NotImplementedException(); }

        public decimal CalculateDiscount(decimal price)
        {
            return 0.5M;
        }
    }
}
