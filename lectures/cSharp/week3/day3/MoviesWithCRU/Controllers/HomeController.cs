<<<<<<< HEAD
﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesWithCRU.Models;

namespace MoviesWithCRU.Controllers;
=======
<<<<<<<< HEAD:assignments/cSharp/DojoSurveyWithValidation/Controllers/HomeController.cs
﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidation.Models;

namespace DojoSurveyWithValidation.Controllers;
>>>>>>> upstream/main

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

<<<<<<< HEAD
    private MyContext db;  // or use _context instead of db

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        db = context; // if you use _context above use it here too
=======
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
>>>>>>> upstream/main
    }

    public IActionResult Index()
    {
<<<<<<< HEAD
        return View("Dashboard");  
=======
        return View();
>>>>>>> upstream/main
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
<<<<<<< HEAD
}
=======
}
========
﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesWithCRU.Models;

namespace MoviesWithCRU.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext db;  // or use _context instead of db

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        db = context; // if you use _context above use it here too
    }

    public IActionResult Index()
    {
        return View("Dashboard");  
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
>>>>>>>> upstream/main:lectures/cSharp/week3/day3/MoviesWithCRU/Controllers/HomeController.cs
>>>>>>> upstream/main
