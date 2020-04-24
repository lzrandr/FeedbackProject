using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackProject.Controllers
{
    public class TeachersController : Controller
    {
        public ViewResult Index()
        {
            var teacher = GetTeacher();
            return View(teacher);
        }
        public ActionResult Details(int id)
        {
            var teacher = GetTeacher().SingleOrDefault(c => c.Id == id);

            if (teacher == null)
                return NotFound();

            return View(teacher);
        }

        private IEnumerable<Teacher> GetTeacher()
        {
            return new List<Teacher>
            {
                new Teacher { Id = 1, Name = "Cristi" },
                new Teacher { Id = 2, Name = "Daniela" }
            };
        }
    }
}