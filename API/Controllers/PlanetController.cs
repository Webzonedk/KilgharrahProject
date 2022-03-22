using API.DAL; // API is our project.
using Microsoft.AspNetCore.Mvc; // AspNetCore is a web framework.
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")] // Route is for guide you in the web-browser.
    [ApiController] // ApiController tells a program, that the class is not an object, but a controller.
    public class PlanetController : ControllerBase
    {
        readonly DBManager manager = new DBManager();

        // GET: api/Planet
        [Route("GetPlanets/All")]
        [HttpGet]
        public string? Get()
        {
            try
            {
                return JsonSerializer.Serialize(manager.GetPlanets(), new JsonSerializerOptions() { WriteIndented = true });
            }
            catch (Exception)
            {
                return null;
            }
        }

        // GET: api/Planet/{id}
        [Route("GetPlanets/{id}")]
        [HttpGet]
        public string? Get(int id)
        {
            //Planet planet = man.GetPlanet(id);

            //string json = JsonSerializer.Serialize(planet);
            try
            {
                return JsonSerializer.Serialize(manager.GetPlanets(id), new JsonSerializerOptions() { WriteIndented = true });
            }
            catch (Exception)
            {
                return null;
            }
        }

        // GET: api/Planet/{id}
        [Route("GetPlanets/{id}/{lang}")]
        [HttpGet]
        public string? Get(int id, string lang)
        {
            //Planet planet = man.GetPlanet(id);

            //string json = JsonSerializer.Serialize(planet);
            try
            {
                return JsonSerializer.Serialize(manager.GetPlanet(id, lang), new JsonSerializerOptions() { WriteIndented = true });
            }
            catch (Exception)
            {
                return null;
            }
        }

        //[HttpGet("{id}/{prop}")]
        //public string Get(int id, string prop)
        //{
        //    return manager.GetPlanetInfo(id, prop);
        //}

        /*
        // GET: api/<PlanetController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PlanetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlanetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlanetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlanetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
