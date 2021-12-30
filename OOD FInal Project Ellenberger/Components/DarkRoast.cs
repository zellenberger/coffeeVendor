namespace DecoratorPattern
{
    /// <summary>
    /// Darkroast class.
    /// </summary>
    public class DarkRoast : Beverage
    {
        /// <summary>
        /// DarkRoast class.
        /// </summary>
        public DarkRoast()
        {
            this.description = "Dark Roast";
            this.cost = 1.20m;
        }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        public override decimal Cost { get => this.cost; set => this.cost = value; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public override string Description { get => this.description; set => this.description = value; }
    }
}