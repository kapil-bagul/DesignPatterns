using System;
using System.Collections.Generic;

namespace StrategyDesign
{
    public class StrategyContext
    {
        int _price;
        Dictionary<string, IOfferStrategy> strategyContext = new Dictionary<string, IOfferStrategy>();

        public StrategyContext(int price)
        {
            this._price = price;
            this.strategyContext.Add(nameof(NoDiscountStrategy), new NoDiscountStrategy());
            this.strategyContext.Add(nameof(QuarterDiscountStrategy), new QuarterDiscountStrategy());
        }

        public void ApplyDiscount(IOfferStrategy strategy)
        {
            Console.WriteLine("Price before offer {0} ", this._price);

            decimal finalPrice =  this._price - ( this._price * strategy.CalculateDiscount(this._price));

            Console.WriteLine("Price after offer {0} ", finalPrice);
        }

        public IOfferStrategy GetStrategy(int month)
        {
            if(month < 6)
            {
                return strategyContext[nameof(NoDiscountStrategy)];
            }
            else
            {
                return strategyContext[nameof(QuarterDiscountStrategy)];
            }
        }
    }
}
