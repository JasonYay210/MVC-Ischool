using IschoolJason.Models;
using IschoolJason.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace IschoolJason.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            /*go get data 
            put the data in the model
            send this result to the view
            */
            DataRetrieval dr = new DataRetrieval();
            // await
            var loadedAbout =  await dr.getData("about/");
            // we now have a string need to cast it to JSON
            // Console.Write(loadedAbout);
            var rtnResult = JsonConvert.DeserializeObject<AboutModel>(loadedAbout);
            rtnResult.pageTitle = "About our iSchool";
            // send the data to the view
            return View(rtnResult);
        }
        public async Task<IActionResult> People()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedpep = await dataR.getData("people/");
            var jsonResult = JsonConvert.DeserializeObject<PeopleModel>(loadedpep);
            jsonResult.pageTitle = "Our People";
            
            return View(jsonResult);
        }
        public async Task<IActionResult> Employment()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedEmployment = await dataR.getData("employment/");
            var jsonResult = JsonConvert.DeserializeObject<EmploymentModel>(loadedEmployment);
            jsonResult.pageTitle = "Employment";

            return View(jsonResult);
        }
        public async Task<IActionResult> Degrees()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedDegrees = await dataR.getData("degrees/");
            var jsonResult = JsonConvert.DeserializeObject<DegreesModel>(loadedDegrees);
            jsonResult.pageTitle = "Our Degrees";

            return View(jsonResult);
        }
        public async Task<IActionResult> Minors()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedMinors = await dataR.getData("minors/");
            var jsonResult = JsonConvert.DeserializeObject<MinorsModel>(loadedMinors);
            jsonResult.pageTitle = "Minors";

            return View(jsonResult);
        }
        public async Task<IActionResult> Course()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedcourse = await dataR.getData("course/");
            var jsonResult = JsonConvert.DeserializeObject<MinorsModel>(loadedcourse);

            return View(jsonResult);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
