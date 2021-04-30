using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Students()
        {
            StudentViewModel svm = new StudentViewModel();

            List<DTO.Students> students = new List<DTO.Students>()
            {
                new DTO.Students{ StudentId = 1, FirstName = "Ted", LastName = "Mosby",
                                    Email = "ted@mosby.ca", Phone = "(204) 999-8765"},
                new DTO.Students{ StudentId = 2, FirstName = "Marshall", LastName = "Eriksen",
                                    Email = "marshall@lawyered.ca", Phone = "(204) 888-7654"},
                new DTO.Students{ StudentId = 3, FirstName = "Barney", LastName = "Stinson",
                                    Email = "barney@pleas.ca", Phone = "(204) 777-6543"}

            };

            svm.Students = students;

            return View(svm);
        }

        public IActionResult Courses()
        {
            CourseViewModel cvm = new CourseViewModel();

            List<DTO.Courses> courses = new List<DTO.Courses>()
            {
                new DTO.Courses{ CourseId = 1, CourseNumber = 100, CourseName = "Cryo 101",
                                    Description = "Ice Basics" },
                new DTO.Courses{ CourseId = 2, CourseNumber = 200, CourseName = "Pyro 101",
                                    Description = "Fire Basics" },
                new DTO.Courses{ CourseId = 3, CourseNumber = 300, CourseName = "Dendro 101",
                                    Description = "Plant Basics" }

            };

            cvm.Courses = courses;

            return View(cvm);
        }

        public IActionResult Instructors()
        {
            InstructorViewModel ivm = new InstructorViewModel();

            List<DTO.Instructors> instructors = new List<DTO.Instructors>()
            {
                new DTO.Instructors{ InstructorId = 1, FirstName = "Arya", LastName = "Stark",
                                    Email = "sansa@stark.ca", Course = "Cryo 101"},
                new DTO.Instructors{ InstructorId = 2, FirstName = "Danaerys", LastName = "Targaryen",
                                    Email = "dany@drogo.ca", Course = "Pyro 101"},
                new DTO.Instructors{ InstructorId = 3, FirstName = "Margaery", LastName = "Tyrell",
                                    Email = "margaery@tyrell.ca", Course = "Dendro 101"}

            };

            ivm.Instructors = instructors;

            return View(ivm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
