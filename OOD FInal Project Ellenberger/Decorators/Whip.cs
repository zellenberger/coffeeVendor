using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    /// <summary>
    /// whip class.
    /// </summary>
    public class Whip : CondimentDecorator
    {
        /// <summary>
        /// whip constructor.
        /// </summary>
        /// <param name="beverage">beverage.</param>
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description += " Whip";
            this.Cost += .25m;
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