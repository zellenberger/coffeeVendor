using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_FInal_Project_Ellenberger.Composite
{
    /// <summary>
    /// Menu class.
    /// </summary>
    public class Menu : MenuComponent
    {
        private ArrayList menuComponents = new ArrayList();

        /// <summary>
        /// menu constructor.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        public Menu(string description, string name)
        {
            this.description = description;
            this.name = name;
        }

        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="menuComponent">menuComponent.</param>
        public override void Add(MenuComponent menuComponent)
        {
            this.menuComponents.Add(menuComponent);
        }

        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="menuComponent">menuComponent.</param>
        public override void Remove(MenuComponent menuComponent)
        {
            this.menuComponents.Remove(menuComponent);
        }

        /// <summary>
        /// get child method.
        /// </summary>
        /// <param name="i">int i.</param>
        /// <returns>MenuComponent.</returns>
        public override MenuComponent GetChild(int i)
        {
            return this.menuComponents[i] as MenuComponent;
        }

        /// <summary>
        /// print method.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"\n{this.Name}, {this.Description}\n-------------------------");

            IEnumerator enumerator = this.menuComponents.GetEnumerator();

            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = enumerator.Current as MenuComponent;
                menuComponent.Print();
            }
        }
    }
}
