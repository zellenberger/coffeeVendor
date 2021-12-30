using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_FInal_Project_Ellenberger.Composite;

namespace OOD_FInal_Project_Ellenberger
{
    /// <summary>
    /// Coffee Enum.
    /// </summary>
    public class CoffeeMenuEnumerator : IEnumerator
    {
        private ArrayList items;
        private int postition;

        /// <summary>
        /// Coffee enum constructor.
        /// </summary>
        /// <param name="items"> items.</param>
        public CoffeeMenuEnumerator(ArrayList items)
        {
            this.items = items;
        }

        /// <summary>
        /// Gets current.
        /// </summary>
        public object Current
        {
            get
            {
                MenuItem menuItem = this.items[this.postition] as MenuItem;
                this.postition++;
                return menuItem;
            }
        }

        /// <summary>
        /// Move next method.
        /// </summary>
        /// <returns>bool.</returns>
        public bool MoveNext()
        {
            bool result = false;

            if (this.postition >= this.items.Capacity || this.items[this.postition] == null)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Reset method.
        /// </summary>
        public void Reset()
        {
            this.postition = 0;
        }
    }
}
