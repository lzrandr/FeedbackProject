using FeedbackProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackProject.ViewModels
{
    public class RandomCourseViewModel
    {
        public Course Course { get; set; }
        public List<FeedBack> Feedback { get; set; } 
    }

    
}
