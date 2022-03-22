namespace Website.Models
{
    public class TranslationTextModel
    {
        /// <summary>
        /// The id from the database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The text in danish
        /// </summary>
        public string? Da { get; set; }
        /// <summary>
        /// The text in english
        /// </summary>
        public string? En { get; set; }
        /// <summary>
        /// The text in hungarian
        /// </summary>
        public string? Hu { get; set; }
    }
}