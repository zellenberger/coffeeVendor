using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern;

namespace OOD_FInal_Project_Ellenberger
{
    /// <summary>
    /// Coffee Factory.
    /// </summary>
    public static class CoffeeFactory
    {
        /// <summary>
        /// Make Coffee Method.
        /// </summary>
        /// <param name="coffeeType"> CoffeeType.</param>
        /// <returns>Beverage.</returns>
        public static Beverage MakeCoffee(string coffeeType)
        {
            Beverage beverage = null;
            switch (coffeeType)
            {
                case "darkroast":
                    beverage = new DarkRoast();
                    Console.WriteLine("Would you like any condiments with your Dark Roast Coffee? (Yes or no)");
                    break;
                case "decaf":
                    beverage = new Decaf();
                    Console.WriteLine("Would you like any condiments with your Decaf Coffee? (Yes or no)");
                    break;
                case "espresso":
                    beverage = new Espresso();
                    Console.WriteLine("Would you like any condiments with your Espresso Coffee? (Yes or no)");
                    break;
                case "houseblend":
                    beverage = new HouseBlend();
                    Console.WriteLine("Would you like any condiments with your House Blend Coffee? (Yes or no)");
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Only the coffee types listed are available, please type one of those.");
                    break;
            }

            return beverage;
        }
    }
}
