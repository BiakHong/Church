using Church.Models;
using Church.Models.Events;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Church.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController : Controller
    {
        private readonly EventLists _context;
        public EventController(EventLists context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var experiences = _context.Events.ToList();
            return View(experiences);
        }
    }
}