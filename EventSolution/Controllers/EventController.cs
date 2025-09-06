using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EventSolution.Models;

namespace EventSolution.Controllers
{
    // [Route("[controller]")]
    public class EventController : Controller
    {
        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        [HttpGet("AllEvents")]
        public IActionResult AllEvents()
        {
            ViewData["Title"] = "Events Page";
            var events = AllEventsList();


            return View("Events", events);
        }

        [HttpGet("")]
        [HttpGet("UpcomingEvents")]
        public IActionResult UpcomingEvents()
        {
            ViewData["Title"] = "Upcoming Events Page";
            var events = AllEventsList().Where(e => e.Date > DateTime.Now).ToList();
            return View("Events", events);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        private List<EventViewModel> AllEventsList()
        {
            List<EventViewModel> events = new List<EventViewModel>();

            EventViewModel event1 = new EventViewModel()
            {
                Name = "Event Past",
                Description = "This is the description of Event 1",
                Date = new DateTime(2023, 12, 25),
                Address = "123 Main St, Cityville",
                AssignedUser = "John Doe",
                Capacity = 100
            };

            EventViewModel event2 = new EventViewModel()
            {
                Name = "Event Today",
                Description = "This is the description of Event 2",
                Date = DateTime.Now,
                Address = "456 Elm St, Townsville",
                AssignedUser = "Jane Smith",
                Capacity = 150
            };

            EventViewModel event3 = new EventViewModel()
            {
                Name = "Event Future",
                Description = "This is the description of Event 3",
                Date = new DateTime(2025, 12, 15),
                Address = "789 Oak St, Villageville",
                AssignedUser = "Alice Johnson",
                Capacity = 200
            };

            events.Add(event1);
            events.Add(event2);
            events.Add(event3);
            return events;


        }
    }
}