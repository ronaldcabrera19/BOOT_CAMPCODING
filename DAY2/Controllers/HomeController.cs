using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DAY2.Models;

namespace DAY2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Details detail = new Details() {
            Firstname = "Ronald",
            Middlename = "Hernandez",
            Lastname = "Cabrera",
            Age = 24
        };
        return View(detail);
    }
}
