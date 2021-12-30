using System;
using DecoratorPattern;
using OOD_FInal_Project_Ellenberger.Composite;

namespace OOD_FInal_Project_Ellenberger
{
    /// <summary>
    /// Program class.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Clay's Robot Coffee Vending Machine");
            Console.Title = "Coffee Vending Machine";

            MenuComponent coffeeMenu = new Menu("COFFEE MENU", "Coffee");

            coffeeMenu.Add(new MenuItem(new DarkRoast()));
            coffeeMenu.Add(new MenuItem(new Decaf()));
            coffeeMenu.Add(new MenuItem(new Espresso()));
            coffeeMenu.Add(new MenuItem(new HouseBlend()));

            CompositeVendingMachine compositeVendingMachine = new CompositeVendingMachine(coffeeMenu);
            compositeVendingMachine.PrintMenu();

            Console.WriteLine("What coffee would you like?");
            CoffeeConsole.OrderCoffee();

            Console.Read();
        }
    }
}
