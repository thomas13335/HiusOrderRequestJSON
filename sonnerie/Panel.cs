namespace Sonnerie
{
    /// <summary>
    /// Beschriftungsdaten für Sonnerie Panel.
    /// </summary>
    public class Panel
    {
        /// <summary>
        /// U3314-05: Sonnerie-Typ: BK, SO, SU, LIFT, ...
        /// </summary>
        public string Kind;

        /// <summary>
        /// Beschriftung, eine oder zwei Zeilen.
        /// </summary>
        public string[] Beschriftung;
    }
}
