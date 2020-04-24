using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackProject.Models
{
    public class TeachedCourse
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public Course Course { get; set; }
        [Key]
        public Teacher Teacher { get; set; }
    }
}
