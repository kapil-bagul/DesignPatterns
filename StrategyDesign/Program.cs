/*
 * Reference: https://codewithshadman.com/strategy-pattern-csharp/
 * The Strategy pattern enables a client to choose which algorithm to use from a family of 
 * algorithms and gives it a simple way to access it.
 */

using System;

namespace StrategyDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext(100);
            Console.WriteLine("Enter month number between 1 and 12");
            var input = Console.ReadLine();
            int month = Convert.ToInt32(input);
            Console.WriteLine("Month =" + month);
            IOfferStrategy strategy =  context.GetStrategy(month);
            context.ApplyDiscount(strategy);
            Console.ReadLine();
            
        }
    }
}
