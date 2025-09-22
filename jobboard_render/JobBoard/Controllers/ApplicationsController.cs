using Microsoft.AspNetCore.Mvc;
using JobBoard.Data;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly AppDbContext _context;
        public ApplicationsController(AppDbContext context) { _context = context; }

        [HttpGet]
        public IActionResult Apply(int jobId)
        {
            ViewBag.JobId = jobId;
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Application app)
        {
            if (ModelState.IsValid)
            {
                _context.Applications.Add(app);
                _context.SaveChanges();
                return RedirectToAction("Index", "Jobs");
            }
            return View(app);
        }
    }
}
