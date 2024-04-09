using Church.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Church.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExperienceLists _context;
        public HomeController(ExperienceLists context)
        {
            _context = context;
        }




        public IActionResult List()
        {
            var productLis = _context.Experiences.OrderBy(m => m.Name).ToList();
            return View();
        }


        public IActionResult Index()
        {
            var productLis = _context.Experiences.OrderBy(m => m.Name).ToList();
            return View("Index", productLis);
        }

        /* public IActionResult Index()
         {
             return View();
         }*/

        public async Task<IActionResult> AddExperience(Experience experience)
        {
            if (ModelState.IsValid)
            {
                var newExperience = new Experience
                {
                    
                    Name = experience.Name,
                    ExperienceTexts = experience.ExperienceTexts,
                    CreatedAt = DateTime.UtcNow

                };

                _context.Experiences.Add(newExperience);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View("Index", _context.Experiences.ToList());
        }
    }
}
