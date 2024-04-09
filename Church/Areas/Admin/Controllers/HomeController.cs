using Church.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Church.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ExperienceLists _context;
        public HomeController(ExperienceLists context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var experiences = _context.Experiences.ToList();
            return View(experiences);
        }
        [HttpPost]
        public IActionResult DeleteExperience(int id)
        {
            var experience = _context.Experiences.Find(id);
            Console.WriteLine("Hello World! 1");

            if (experience == null)
            {
                Console.WriteLine("Hello World! - Experience not found");
                return NotFound();
            }

            Console.WriteLine("Hello World! 2 - Experience found");

            try
            {
                _context.Experiences.Remove(experience);
                _context.SaveChanges();

                Console.WriteLine("Hello World! 3 - Experience deleted");

                TempData["UserMessage"] = "Experience deleted.";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hello World! - Exception: " + ex.Message);
                throw; // Re-throwing the exception for debugging purposes
            }

            return RedirectToAction(nameof(Index));
        }




    }
}
