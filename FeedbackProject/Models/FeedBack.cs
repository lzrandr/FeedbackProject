using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackProject.Models
{
    public class FeedBack
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("TeachedCourse")]
        public int TeachedCourseId { get; set; }
        public virtual TeachedCourse TeachedCourse { get; set; }
        [Required]
        public string FeedbackWriterName { get; set; }
        [Required]
        [EmailAddress]
        public string FeedbackWriterEmail { get; set; }
        [Required]
        public string Feedback { get; set; }
        [Required]
        public DateTime Date { get { return DateTime.Now; } }
    }
}
