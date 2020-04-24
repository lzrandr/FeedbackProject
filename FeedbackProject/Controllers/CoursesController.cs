using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackProject.Models;
using FeedbackProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackProject.Controllers
{
    public class CoursesController : Controller
    {
        public ViewResult Index()
        {
            var courses = GetCourses();

            return View(courses);
        }

        private IEnumerable<Course> GetCourses()
        {
            return new List<Course>
            {
                new Course { Id = 1, CourseName = "Java" },
                new Course { Id = 2, CourseName = "PHP" }
            };
        }



        // GET: Courses/Random
        public IActionResult Random()
        {
            var course = new Course() { CourseName = "Java" };
            var teachers = new List<Teacher>
            {
            new Teacher { Name = "Alina"},
            new Teacher { Name = "Bogdan"}
            };

            var viewModel = new RandomCourseViewModel
            {
                Course = course,
                Teachers = teachers
            };

            return View(viewModel);
        }
    }
}