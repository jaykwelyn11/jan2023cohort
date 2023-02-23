using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
public class FormController : Controller
{


    // [HttpPost("postRequest")]
    // public IActionResult Form(string name, string location, string favLang, string comment)
    // {
    //     ViewBag.name = $"{name}";
    //     ViewBag.location = $"{location}";
    //     ViewBag.favLang = $"{favLang}";
    //     ViewBag.comment = $"{comment}";

    //     return RedirectToAction("Form");
    // }

    [HttpGet("form")]
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost("form")]
    public IActionResult Form(string name, string location, string favLang, string comment)
    {
        ViewBag.name = $"{name}";
        ViewBag.location = $"{location}";
        ViewBag.favLang = $"{favLang}";
        ViewBag.comment = $"{comment}";

        return View();
    }
}
