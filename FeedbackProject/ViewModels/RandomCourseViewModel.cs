using FeedbackProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackProject.ViewModels
{
    public class RandomCourseViewModel
    {
        public Course Course { get; set; }
        public List<Teacher> Teachers {get; set; }
    }
}
