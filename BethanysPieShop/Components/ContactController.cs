using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Components;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
