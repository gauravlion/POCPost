namespace PostPOC.Model
{
    /// <summary>
    /// Class Address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>The street.</value>
        public string street { get; set; }
        /// <summary>
        /// Gets or sets the suite.
        /// </summary>
        /// <value>The suite.</value>
        public string suite { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string city { get; set; }
        /// <summary>
        /// Gets or sets the zipcode.
        /// </summary>
        /// <value>The zipcode.</value>
        public string zipcode { get; set; }
        /// <summary>
        /// Gets or sets the geo.
        /// </summary>
        /// <value>The geo.</value>
        public Geo geo { get; set; }
    }
}
