using Microsoft.AspNetCore.Mvc;
using QuickSurvey.Data;

namespace QuickSurvey.Controllers;

public class SurveyController : Controller
{
    [HttpGet("/api/Uebung1")]
    public IActionResult GetResponsesUebung1()
    {
        return Ok(ResponseStore.GetAllUebung1());
    }

    [HttpGet("/api/Uebung2")]
    public IActionResult GetResponsesUebung2()
    {
        return Ok(ResponseStore.GetAllUebung2());
    }

    [HttpGet("/api/Uebung3")]
    public IActionResult GetResponsesUebung3()
    {
        return Ok(ResponseStore.GetAllUebung3());
    }

    [HttpGet("/api/Uebung1/Reset")]
    public IActionResult ResetStoreUebung1()
    {
        ResponseStore.ResetUebung1();
        return NoContent();
    }

    [HttpGet("/api/Uebung2/Reset")]
    public IActionResult ResetStoreUebung2()
    {
        ResponseStore.ResetUebung2();
        return NoContent();
    }

    [HttpGet("/api/Uebung3/Reset")]
    public IActionResult ResetStoreUebung3()
    {
        ResponseStore.ResetUebung3();
        return NoContent();
    }
}