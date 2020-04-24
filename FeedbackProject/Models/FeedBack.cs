using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackProject.Models
{
    public class FeedBack
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public TeachedCourse TeachedCourse { get; set; }
        public string Feedback { get; set; }

    }
}
