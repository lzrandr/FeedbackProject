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
            return new List<Course>();
        }



        // GET: Courses/Random
        public IActionResult Random()
        {

            var viewModel = new RandomCourseViewModel();
           

            return View(viewModel);
        }
    }
}