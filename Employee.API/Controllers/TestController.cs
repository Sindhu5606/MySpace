using Employee.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTestForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            //hey someone, could you look at this request and process it, return the data please
            return null;
        }

        [HttpPut(Name = "UpdateExisting")]
        public string UpdateExisting(string id)
        {
            Human prem = new Human();
            return prem.FetchUpdateText(id);
        }

        [HttpPost(Name = "CreateNew")]
        public string CreateNew(string name)
        {
            return "create a new item called {name}";
        }
    }
}
