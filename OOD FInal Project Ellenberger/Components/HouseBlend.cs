namespace DecoratorPattern
{
    /// <summary>
    /// Housebland class.
    /// </summary>
    public class HouseBlend : Beverage
    {
        /// <summary>
        /// house blend.
        /// </summary>
        public HouseBlend()
        {
            this.description = "House Blend";
            this.cost = 1.10m;
        }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        public override decimal Cost { get => this.cost; set => this.cost = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public override string Description { get => this.description; set => this.description = value; }
    }
}