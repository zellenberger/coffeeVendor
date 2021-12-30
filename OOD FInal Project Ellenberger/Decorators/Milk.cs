using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    /// <summary>
    /// Milk class.
    /// </summary>
    public class Milk : CondimentDecorator
    {
        /// <summary>
        /// Milk constructor.
        /// </summary>
        /// <param name="beverage">beverage.</param>
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description += " Milk";
            this.Cost += .10m;
        }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        public override decimal Cost { get => this.beverage.Cost; set => this.beverage.Cost = value; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public override string Description { get => this.beverage.Description; set => this.beverage.Description = value; }
    }
}