using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackProject.Models
{
    public class TeachedCourse
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [Required]
        public virtual Course Course { get; set; }
       
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        [Required]
        public virtual Teacher Teacher { get; set; }
    }
}
