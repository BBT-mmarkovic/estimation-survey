using System.Collections.Concurrent;
using Jdenticon.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace QuickSurvey.Controllers
{
    public class IdenticonController : Controller
    {
        private ConcurrentDictionary<string, IdenticonResult> cachedResults = new ();

        [HttpGet("/api/Icon/")]
        public IActionResult Index()
        {
            return IdenticonResult.FromValue("Value to be hashed", size: 100);
        }

        [HttpGet("/api/Icon/{id}")]
        public IActionResult GetById(string id)
        {
            IdenticonResult result;
            if (cachedResults.TryGetValue(id, out result))
            {
                return result;
            }

            var identiconResult = IdenticonResult.FromValue(id, size: 100);
            cachedResults.TryAdd(id, identiconResult);

            return identiconResult;
        }
    }
}
