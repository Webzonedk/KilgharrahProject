namespace Website.Models
{
    public class PlanetModel
    {
        /// <summary>
        /// Id is the Id for the DataBase.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The language
        /// </summary>
        public string? Lang { get; set; }
        /// <summary>
        /// All the information as JSON
        /// </summary>
        public string? Info_as_json { get; set; }
    }
}
