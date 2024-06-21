using System.Diagnostics;
using DAY3.Model;
using Microsoft.AspNetCore.Mvc;
using DAY3.Models;

namespace DAY3.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        Inventory inventory = new Inventory (
            101, "KISS", "SNACK", "1A2F3", 34, "02/12/2024"
        );
        return View(inventory);
    }
}
