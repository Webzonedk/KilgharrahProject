using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Website.Models;
using Website.DAL;
using System.Text.Json;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            // Local testing
            //return View(Tuple.Create(JsonSerializer.Deserialize<List<PlanetModel>>(System.IO.File.ReadAllText(@"C:\Users\marcu\Desktop\apiData.json")), ""));

            try
            {
                APIManager apiManager = new APIManager();
                //await apiManager.GetPlanets();
                //await apiManager.GetTranslation();

                return View(Tuple.Create(await apiManager.GetPlanets(), await apiManager.GetTranslation()));
            }
            catch (Exception)
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}