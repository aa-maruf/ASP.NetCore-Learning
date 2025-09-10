using System.Diagnostics;
using Ayojon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ayojon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllEvents()
        {
            List<Event> events = SampleData.getAllEvents();
            return View(events);
        }

        public IActionResult Users()
        {

            return View(SampleData.getAllUsers());
        }

        public IActionResult NextEvents()
        {
            List<Event> SavedEvents = new List<Event>();
            foreach (var ev in SampleData.getAllEvents()) 
            {
                if (ev.date > DateTime.Now)
                {
                    SavedEvents.Add(ev);
                }
            }

            return View(SavedEvents);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
