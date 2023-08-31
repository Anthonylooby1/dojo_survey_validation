using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dojo_survey_validation.Models;
using System.Formats.Asn1;

namespace dojo_survey_validation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public static List<DojoSurvey> SurveyAnswerList = new();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("form/create")]
    public IActionResult TakeSurvey(DojoSurvey p)
    {
        if(ModelState.IsValid)
        {
        Console.WriteLine($"{p.name} {p.language} {p.location} {p.comment}");
        return View("SurveyAnswer", p);

        }
        return View("Index");
    }

    [HttpGet("results")]
    public ViewResult Form()
    {
        return View("SurveyAnswer", SurveyAnswerList);
    }

    [HttpGet("privacy")]
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
