using Microsoft.AspNetCore.Mvc;

namespace ChurchWebsite.Controllers
{
    public class Contacts : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
