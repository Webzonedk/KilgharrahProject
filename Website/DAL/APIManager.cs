using System.Text.Json;
using Website.Models;

namespace Website.DAL
{
    /// <summary>
    /// Manages the connection to the API
    /// </summary>
    public class APIManager
    {
        /// <summary>
        /// The HttpClient
        /// </summary>
        private readonly HttpClient _client = new HttpClient();
        //private readonly string _baseAdress = "https://localhost:7156/api/";
        private readonly string _baseAdress = "http://192.168.1.123:5000/api/";
        /// <summary>
        /// Creates a new instance of the APIManager
        /// </summary>
        public APIManager()
        {

        }
        /// <summary>
        /// Get a list of all planets
        /// </summary>
        /// <returns>This method a List of Planets </returns>
        public async Task<List<PlanetModel>> GetPlanets()
        {
            string json = await _client.GetStringAsync($"{_baseAdress}Planet/GetPlanets/All");
            
            List<PlanetModel>? planets = JsonSerializer.Deserialize<List<PlanetModel>>(json);

            return planets ?? new List<PlanetModel>();
        }
        /// <summary>
        /// Get a list of all translations, in all languages available
        /// </summary>
        /// <returns>This method returns a list of TranslationText</returns>
        public async Task<List<TranslationTextModel>> GetTranslation()
        {
            string json = await _client.GetStringAsync($"{_baseAdress}Translations/GetTranslations/All");

            List<TranslationTextModel>? text = JsonSerializer.Deserialize<List<TranslationTextModel>>(json);

            return text ?? new List<TranslationTextModel>();
        }
    }
}
