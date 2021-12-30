using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_FInal_Project_Ellenberger.Composite
{
    /// <summary>
    /// Composite vending machine class.
    /// </summary>
    public class CompositeVendingMachine
    {
        /// <summary>
        /// Menu.
        /// </summary>
        private MenuComponent menu;

        /// <summary>
        /// Composite vending machine method.
        /// </summary>
        /// <param name="menu">menu.</param>
        public CompositeVendingMachine(MenuComponent menu)
        {
            this.menu = menu;
        }

        /// <summary>
        /// Print menu method.
        /// </summary>
        public void PrintMenu()
        {
            this.menu.Print();
        }
    }
}
