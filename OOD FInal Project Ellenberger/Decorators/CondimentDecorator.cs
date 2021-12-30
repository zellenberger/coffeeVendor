using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    /// <summary>
    /// CondimentDecorator class.
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        /// <summary>
        /// beverage field.
        /// </summary>
        public Beverage beverage;

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        public abstract override decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public abstract override string Description { get; set; }
    }
}
