using API.Models;
using Npgsql;
using System.Reflection;

namespace API.DAL
{
    /// <summary>
    /// Class for managing the DataBase.
    /// </summary>
    public class DBManager
    {
        private NpgsqlConnection Connection;
        private readonly string _connectionString = "Host=192.168.1.121;Username=postgres;Password=Code1234@;Database=Kilgharrah";
        public DBManager()
        {
            Connection = new NpgsqlConnection(_connectionString);

            //string sql = "SELECT version()";
            //NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection);
            //string outPut = cmd.ExecuteScalar().ToString();

        }
        public void Open()
        {
            Connection.Open();
        }
        public void Close()
        {
            Connection.Close();
        }
        /// <summary>
        /// Method for getting all planets and all the information.
        /// </summary>
        /// <returns></returns>
        public List<PlanetModel> GetPlanets()
        {
            Open();
            List<PlanetModel> planets = new List<PlanetModel>();
            string sql = "SELECT * FROM planets";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection)) // "Using" automatically disposes of objects after use.
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PlanetModel planet = new PlanetModel();
                        int i = 0;

                        // This loop gets all the properties from the DataBase and sets them to the object.
                        foreach (PropertyInfo property in planet.GetType().GetProperties().Where(PropInfo => !PropInfo.GetGetMethod().GetParameters().Any()))
                        {
                            property.SetValue(planet, reader.GetValue(i++));
                            //Console.WriteLine($"{p.Name}: \"{p.GetValue(planet, null)}\"");
                        }

                        planets.Add(planet);
                    }

                    Close();
                    return planets;
                }
            }
        }
        /// <summary>
        /// Gets a single Planet Object from an ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>This method returns a planet.</returns>
        public List<PlanetModel> GetPlanets(int id)
        {
            Open();
            List<PlanetModel> planets = new List<PlanetModel>();
            string sql = $"SELECT * FROM planets WHERE id = '{id}'";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection)) // "Using" automatically disposes of objects after use.
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PlanetModel planet = new PlanetModel();
                        int i = 0;

                        // This loop gets all the properties from the DataBase and sets them to the object.
                        foreach (PropertyInfo property in planet.GetType().GetProperties().Where(PropInfo => !PropInfo.GetGetMethod().GetParameters().Any()))
                        {
                            property.SetValue(planet, reader.GetValue(i++));
                            //Console.WriteLine($"{p.Name}: \"{p.GetValue(planet, null)}\"");
                        }

                        planets.Add(planet);
                    }
                    Close();
                    return planets;
                }
            }
        }
        public PlanetModel GetPlanet(int id, string lang)
        {
            Open();
            string sql = $"SELECT * FROM Planets WHERE id = '{id}' AND lang = '{lang.Substring(0, 2)}'";
            PlanetModel planet = new PlanetModel();

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows == false)
                    {
                        return null;
                    }
                    while (reader.Read())
                    {
                        int i = 0;

                        foreach (PropertyInfo property in planet.GetType().GetProperties().Where(PropInfo => !PropInfo.GetGetMethod().GetParameters().Any()))
                        {
                            property.SetValue(planet, reader.GetValue(i++));
                        }

                    }
                }
            }
            Close();
            return planet;
        }
        /// <summary>
        /// Get a single property from a single planet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prop"></param>
        /// <returns>This method returns a single property as a string</returns>
        public string GetPlanetInfo(int id, string lang, string prop)
        {
            PlanetModel planet = GetPlanet(id, lang);

            return planet.GetType().GetProperty(prop).GetValue(planet, null).ToString();
        }
        /// <summary>
        /// Get a list of all TranslationTexts
        /// </summary>
        /// <returns>This method returns a List of TranslationText</returns>
        public List<TranslationTextModel> GetTranslations()
        {
            Open();
            List<TranslationTextModel> translations = new List<TranslationTextModel>();
            string sql = "SELECT * FROM TranslationText";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TranslationTextModel translationText = new TranslationTextModel();
                        int i = 0;

                        // This loop gets all the properties from the DataBase and sets them to the object.
                        foreach (PropertyInfo property in translationText.GetType().GetProperties().Where(PropInfo => !PropInfo.GetGetMethod().GetParameters().Any()))
                        {
                            property.SetValue(translationText, reader.GetValue(i++));
                            //Console.WriteLine($"{p.Name}: \"{p.GetValue(planet, null)}\"");
                        }

                        translations.Add(translationText);
                    }
                    Close();
                    return translations;
                }
            }
        }
    }
}
