namespace Sonnerie
{
    public class ObjectRecord : PostalLocation
    {
        /// <summary>
        /// Eidgenössische Gebäude Identifikation, optional.
        /// </summary>
        public string EGID;

        /// <summary>
        /// Objekt-Referenz Verwaltung.
        /// </summary>
        public string ID;

        /// <summary>
        /// Angabe Stockwerk, optional, für Lieferschein.
        /// </summary>
        public string Floor;

        /// <summary>
        /// Angabe Wohnung, optional, für Lieferschein.
        /// </summary>
        public string Position;

        /// <summary>
        /// Externe Objekt-Referenz, optional.
        /// </summary>
        public string ExternalObjectNumber;
    }
}
