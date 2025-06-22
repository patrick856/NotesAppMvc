using Microsoft.AspNetCore.Mvc;

public class HomeController : ControllerBase
{
    public IActionResult Index() => RedirectToAction("Index", "Notes");
}