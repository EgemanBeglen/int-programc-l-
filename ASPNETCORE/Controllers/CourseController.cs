using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPNETCORE.Models;

namespace ASPNETCORE.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.id= 1;
        kurs.Title= "ASPNETCORE";
        kurs.Description= "MVC";
        return View(kurs);
    }

    public IActionResult List()
    {
       //Liste
       var kurslar = new List<Course>()
        {
            new Course() {id=1, Title="ASP", Description="dotnet"},
            new Course() {id=2, Title="Java", Description="Temel kavramlar"},
            new Course() {id=3, Title="Javascript", Description="Metotlar"}
        };
       return View(kurslar);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
