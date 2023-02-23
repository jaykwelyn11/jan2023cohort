using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet("/result")]
    public IActionResult RegForm()
    {
        return View();
    }


    // [HttpPost("postRequest")]
    // public IActionResult Form(string name, string location, string favLang, string comment)
    // {
    //     ViewBag.name = $"{name}";
    //     ViewBag.location = $"{location}";
    //     ViewBag.favLang = $"{favLang}";
    //     ViewBag.comment = $"{comment}";

    //     return RedirectToAction("Form");
    // }

    // [HttpGet("form")]
    // public IActionResult Form()
    // {
    //     return View();
    // }

    // [HttpPost("form")]
    // public IActionResult Form(string name, string location, string favLang, string comment)
    // {
    //     ViewBag.name = $"{name}";
    //     ViewBag.location = $"{location}";
    //     ViewBag.favLang = $"{favLang}";
    //     ViewBag.comment = $"{comment}";

    //     return View();
    // }
}
