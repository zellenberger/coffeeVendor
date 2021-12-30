namespace DecoratorPattern
{
    /// <summary>
    /// Decaf class.
    /// </summary>
    public class Decaf : Beverage
    {
        /// <summary>
        /// Decaf method.
        /// </summary>
        public Decaf()
        {
            this.description = "Decaf";
            this.cost = 1.00m;
        }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        public override decimal Cost { get => this.cost; set => this.cost = value; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public override string Description { get => this.description; set => this.description = value; }
    }
}