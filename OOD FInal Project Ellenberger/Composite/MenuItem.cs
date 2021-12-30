using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern;

namespace OOD_FInal_Project_Ellenberger.Composite
{
    /// <summary>
    /// MenuItem class.
    /// </summary>
    public class MenuItem : MenuComponent
    {
        /// <summary>
        /// MenuItem constructor.
        /// </summary>
        /// <param name="beverage">beverage.</param>
        public MenuItem(Beverage beverage)
        {
            this.description = beverage.Description;
            this.price = beverage.Cost;
        }

        /// <summary>
        /// print method.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"\t{this.Description}, Cost: ${this.Price}\n\t\t--");
        }
    }
}
