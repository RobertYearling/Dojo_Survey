using System;
using Microsoft.AspNetCore.Mvc;


namespace DojoSurvey.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(string name, string location, string language, string comments)
        {
            Console.WriteLine($"{name}\n{location}\n{language}\n{comments}");
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comments = comments;
            return View("Result");
        }

        // public IActionResult Index()  // Action Method
        // {
        //     return View("Result");
        // }
        //
        // --------------
        //
        // [HttpGet("another")]
        // public IActionResult Another()
        // {
        //     return View();
        // }

        // [HttpGet("Redirect")]
        // public IActionResult Redirect()
        // {
        //     return RedirectToAction("Another");
        // }
    }
}