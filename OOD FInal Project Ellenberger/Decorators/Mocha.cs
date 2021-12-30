using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    /// <summary>
    /// Mocha class.
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        /// <summary>
        /// Mocha constructor.
        /// </summary>
        /// <param name="beverage">beverage.</param>
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description += " Mocha";
            this.Cost += .15m;
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