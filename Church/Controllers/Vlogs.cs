using Microsoft.AspNetCore.Mvc;

namespace ChurchWebsite.Controllers
{
    public class Vlogs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
