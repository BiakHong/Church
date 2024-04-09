using Microsoft.AspNetCore.Mvc;

namespace ChurchWebsite.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
