using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern;
using OOD_FInal_Project_Ellenberger.Composite;

namespace OOD_FInal_Project_Ellenberger
{
    /// <summary>
    /// coffee console.
    /// </summary>
    public class CoffeeConsole
    {
        /// <summary>
        /// Order coffee.
        /// </summary>
        public static void OrderCoffee()
        {
            Beverage beverage = null;
            while (beverage == null)
            {
                string userInput = Console.ReadLine();
                beverage = CoffeeFactory.MakeCoffee(userInput);
            }

            Beverage decaf = new Decaf();
            decaf.Cost = 0;
            decaf.Description = string.Empty;
            MenuComponent condimentMenu = new Menu("CONDIMENT MENU", "Condiment");
            condimentMenu.Add(new MenuItem(new Milk(decaf)));
            decaf = new Decaf();
            decaf.Cost = 0;
            decaf.Description = string.Empty;
            condimentMenu.Add(new MenuItem(new Mocha(decaf)));
            decaf = new Decaf();
            decaf.Cost = 0;
            decaf.Description = string.Empty;
            condimentMenu.Add(new MenuItem(new Soy(decaf)));
            decaf = new Decaf();
            decaf.Cost = 0;
            decaf.Description = string.Empty;
            condimentMenu.Add(new MenuItem(new Whip(decaf)));
            CompositeVendingMachine compositeVendingMachine = new CompositeVendingMachine(condimentMenu);
            compositeVendingMachine.PrintMenu();

            string input = Console.ReadLine();
            while (input == "yes")
            {
                beverage = Condiment(beverage);
                Console.WriteLine($"\t{beverage.Description}\n\t\t--");
                Console.WriteLine("Would you like to add more condiments to your coffee? (Yes or no)");
                input = Console.ReadLine();
            }

            Console.WriteLine($" You ordered a\t{beverage.Description}, which costs ${beverage.Cost}\n\t\t--");
        }

        /// <summary>
        /// condiment method.
        /// </summary>
        /// <param name="beverage">beverage.</param>
        /// <returns>beverage..</returns>
        public static Beverage Condiment(Beverage beverage)
        {
            Beverage coffee = new Decaf();
            coffee.Cost = 0;
            coffee.Description = string.Empty;
            Console.WriteLine("What condiments would you like to add to your coffee");
            Beverage condiment;
            condiment = new Milk(coffee);
            string input = string.Empty;
            input = Console.ReadLine().ToLower();
            switch (input)
                {
                    case "milk":
                        Console.WriteLine("Milk added to coffee");
                        condiment = new Milk(beverage);
                        break;
                    case "mocha":
                        Console.WriteLine("Mocha added to coffee");
                        condiment = new Mocha(beverage);
                        break;
                    case "soy":
                        Console.WriteLine("Soy added to coffee");
                        condiment = new Soy(beverage);
                        break;
                    case "whip":
                        Console.WriteLine("Whip added to coffee");
                        condiment = new Whip(beverage);
                        break;
                }

            return condiment;
        }
    }
}
