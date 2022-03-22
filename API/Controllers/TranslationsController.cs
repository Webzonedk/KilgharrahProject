using API.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationsController : ControllerBase
    {
        readonly DBManager manager = new DBManager();

        // GET: api/Translations
        [Route("GetTranslations/All")]
        [HttpGet]
        public string? Get()
        {
            try
            {
            return JsonSerializer.Serialize(manager.GetTranslations(), new JsonSerializerOptions() { WriteIndented = true });
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}