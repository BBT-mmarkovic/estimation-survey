using Microsoft.AspNetCore.Mvc;

namespace QuickSurvey.Controllers
{
    public class RandomNameGeneratorController : Controller
    {
        [HttpGet("/api/NextName/")]
        public IActionResult Index()
        {
            return Ok(RandomNameGenerator.NextRandomName());
        }
    }
}
