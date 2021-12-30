using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    /// <summary>
    /// Soy class.
    /// </summary>
    public class Soy : CondimentDecorator
    {
        /// <summary>
        /// Soy constructor.
        /// </summary>
        /// <param name="beverage">beverage.</param>
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description += " Soy";
            this.Cost += .20m;
        }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        public override decimal Cost { get => this.beverage.Cost; set => this.beverage.Cost = value; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        public override string Description { get => this.beverage.Description; set => this.beverage.Description = value; }
    }
}