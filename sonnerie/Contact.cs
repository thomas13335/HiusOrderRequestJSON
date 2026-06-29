namespace Sonnerie
{
    /// <summary>
    /// Order contact information.
    /// </summary>
    public class Contact : PostalLocation
    {
        /// <summary>
        /// Optionally the first-name of a person.
        /// </summary>
        public string FirstName;

        /// <summary>
        /// Optionally the last-name of a person.
        /// </summary>
        public string LastName;

        /// <summary>
        /// Aka [Organization]
        /// </summary>
        public string CompanyName;

        /// <summary>
        /// Phone number associated with the contact.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Consider E.164 formatting.
        /// </para>
        /// </remarks>
        public string PhoneNumber;

        /// <summary>
        /// Optionally the email address.
        /// </summary>
        public string Email;

        /// <summary>
        /// Optionally identifies the preferred language.
        /// </summary>
        /// <remarks>
        /// <para>
        /// ISO 639-1 two-letter alphanumeric code: en, de, fr, it, ...
        /// </para>
        /// </remarks>
        public string Language;

        /// <summary>
        /// Optionally a collection of textual message.
        /// </summary>
        public string[] Remarks;
    }
}
