using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_FInal_Project_Ellenberger.Composite
{
    /// <summary>
    /// MenuComponent class.
    /// </summary>
    public class MenuComponent
    {
        /// <summary>
        /// description field.
        /// </summary>
        protected string description;

        /// <summary>
        /// name field.
        /// </summary>
        protected string name;

        /// <summary>
        /// price field.
        /// </summary>
        protected decimal price;

        /// <summary>
        /// Gets the description.
        /// </summary>
        public string Description { get => this.description; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get => this.name; }

        /// <summary>
        /// Gets the price.
        /// </summary>
        public decimal Price { get => this.price; }

        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="menuComponent">menuComponent.</param>
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="menuComponent">menucomponent.</param>
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// get child.
        /// </summary>
        /// <param name="i">int i.</param>
        /// <returns>MenuComponent.</returns>
        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// print method.
        /// </summary>
        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
