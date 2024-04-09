using Microsoft.AspNetCore.Mvc;

namespace ChurchWebsite.Controllers
{
    public class Ministries : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
