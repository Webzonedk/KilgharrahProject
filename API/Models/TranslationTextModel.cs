namespace API.DAL
{
    public class TranslationTextModel
    {
        /// <summary>
        /// The id from the database
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// The text in danish
        /// </summary>
        public string? Da { get; private set; }
        /// <summary>
        /// The text in english
        /// </summary>
        public string? En { get; private set; }
        /// <summary>
        /// The text in hungarian
        /// </summary>
        public string? Hu { get; private set; }
    }
}