namespace DecoratorPattern
{
    /// <summary>
    /// Beverage class.
    /// </summary>
    public abstract class Beverage
    {
        /// <summary>
        /// cost.
        /// </summary>
        protected decimal cost;

        /// <summary>
        /// description.
        /// </summary>
        protected string description = "Unknown Beverage";

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        public abstract decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public abstract string Description { get; set; }
    }
}