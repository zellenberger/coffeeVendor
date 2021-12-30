namespace DecoratorPattern
{
    /// <summary>
    /// Espresso class.
    /// </summary>
    public class Espresso : Beverage
    {
        /// <summary>
        /// Espresso method.
        /// </summary>
        public Espresso()
        {
            this.description = "Espresso";
            this.cost = 1.50m;
        }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        public override decimal Cost { get => this.cost; set => this.cost = value; }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        public override string Description { get => this.description; set => this.description = value; }
    }
}