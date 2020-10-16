using System;
namespace StrategyDesign
{
    public interface IOfferStrategy
    {
        string Name { get; set; }

        decimal CalculateDiscount(decimal price);
    }
}
