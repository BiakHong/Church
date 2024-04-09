using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Church.Models;
using static Church.Models.ExperienceLists;
using System.Diagnostics.Eventing.Reader;


namespace Church.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly ExperienceLists _context;
        public ExperienceController(ExperienceLists context)
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
            return View("list", productLis);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit", new Experience());
        }


        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Add(experience);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(experience);
        }



        [HttpPost]
        public IActionResult Add(Experience experience)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = $"{experience.Name} was added.";
                Save(experience);
                return RedirectToAction("List");

            }
            else
            {
                ViewBag.Action = "Add";
                return View("AddEdit", experience);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var experience = _context.Experiences.Find(id);
            return View("AddEdit", experience);
        }
        [HttpPost]
        public IActionResult Edit(Experience experience)
        {
            if (ModelState.IsValid)
            {
                if (experience.Id == 0)
                {


                    _context.Experiences.Add(experience);
                }
                else
                    _context.Experiences.Update(experience);
                _context.SaveChanges();
                TempData["SuccessMessage"] = $"{experience.Name} was updated.";
                return RedirectToAction("List", "Experience");
            }
            else
            {
                ViewBag.Action = (experience.Id == 0) ? "Add" : "Edit";
                return View("AddEdit", experience);
            }
        }
        [HttpGet]
        public IActionResult Save(int id)
        {
            ViewBag.Action = "Edit";
            var experience = _context.Experiences.Find(id);
            return View("AddEdit", experience);
        }
        [HttpPost]
        public IActionResult Save(Experience experience)
        {
            if (ModelState.IsValid)
            {
                if (experience.Id == 0)
                {
                    _context.Experiences.Add(experience);
                    ViewBag.Action = "Add"; // Set the ViewBag.Action value to "Add" for new experiences
                }
                else
                {
                    _context.Experiences.Update(experience);
                    ViewBag.Action = "Edit"; // Set the ViewBag.Action value to "Edit" for existing experiences
                }
                _context.SaveChanges();
                return RedirectToAction("List", "Experience");
            }
            else
            {
                ViewBag.Action = (experience.Id == 0) ? "Add" : "Edit"; // Set the ViewBag.Action value based on the experience.Id
                return View(experience);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var experience = _context.Experiences.Find(id);
            if (experience == null)
            {
                return NotFound();
            }
            return View(experience);
        }
        [HttpPost]
        public IActionResult Delete(Experience experience)
        {
            if (experience == null)
            {
                return BadRequest();
            }
            TempData["SuccessMessage"] = "Experience Deleted successfully.";
            _context.Experiences.Remove(experience);
            _context.SaveChanges();
            return RedirectToAction("List", "Experience");
        }
    }
}