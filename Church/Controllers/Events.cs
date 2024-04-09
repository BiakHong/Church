using Microsoft.AspNetCore.Mvc;

namespace ChurchWebsite.Controllers
{
    public class Events : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
