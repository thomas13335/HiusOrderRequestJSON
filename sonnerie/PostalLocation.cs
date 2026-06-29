namespace Sonnerie
{
    /// <summary>
    /// Basic postal location information.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Please consider validating postal location data against an official catalog.
    /// For Switzerland such data is provided by https://www.geo.admin.ch/.
    /// </para>
    /// </remarks>
    public class PostalLocation
    {
        #region Elements

        /// <summary>
        /// Street-name and house-number, separated by whitespace.
        /// </summary>
        public string StreetAddress;

        /// <summary>
        /// Numeric postal code.
        /// </summary>
        public string PostalCode;

        /// <summary>
        /// Locality name.
        /// </summary>
        public string Locality;

        /// <summary>
        /// ISO Ländercode alphanumerisch, zweistellig.
        /// </summary>
        public string Country;

        #endregion
    }
}
