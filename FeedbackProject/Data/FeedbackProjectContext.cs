using FeedbackProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackProject.Data
{
    public class FeedbackProjectContext : DbContext
    {

        public FeedbackProjectContext(DbContextOptions<FeedbackProjectContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<FeedBack> Feedbacks { get; set; }

        public DbSet<TeachedCourse> TeachedCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Teacher>().HasData(
            new Teacher
            {
                Id = 1,
                FirstName = "Alin",
                LastName = "Bradut",
                Email = "ab@feedback.com"
            },
             new Teacher
             {
                 Id = 2,
                 FirstName = "Larisa",
                 LastName = "Costache",
                 Email = "lc@feedback.com"
             },
            new Teacher
            {
                Id = 3,
                FirstName = "George",
                LastName = "Trifan",
                Email = "gt@feedback.com"
            },
             new Teacher
             {
                 Id = 4,
                 FirstName = "Ovidiu",
                 LastName = "Netoiu",
                 Email = "on@feedback.com"
             }
        );

            modelBuilder.Entity<Course>().HasData(
        new Course
        {
            Id = 1,
            CourseName = "Java",
        },
         new Course
         {
             Id = 2,
             CourseName = "Python",
         }, new Course
         {
             Id = 3,
             CourseName = "Javascrip",
         }, new Course
         {
             Id = 4,
             CourseName = "PHP",
         }
         );

            modelBuilder.Entity<TeachedCourse>().HasData(
          new TeachedCourse
          {
              Id = 1,
              CourseId = 1,
              TeacherId = 1,
          },
          new TeachedCourse
          {
              Id = 2,
              CourseId = 2,
              TeacherId = 2,
          },
           new TeachedCourse
           {
               Id = 3,
               CourseId = 3,
               TeacherId = 3,
           }
          );

            modelBuilder.Entity<FeedBack>().HasData(
            new FeedBack
            {
                Id = 1,
                TeachedCourseId = 1,
                FeedbackWriterName = "Bogdan Tudorica",
                Feedback = "Totul a fost bine",
                FeedbackWriterEmail = "a@a.com",
            },
             new FeedBack
             {
                 Id = 2,
                 TeachedCourseId = 1,
                 FeedbackWriterName = "Jan Constatin",
                 Feedback = "Nu totul a fost bine",
                 FeedbackWriterEmail = "b@b.com",
             },
             new FeedBack
             {
                 Id = 3,
                 TeachedCourseId = 2,
                 FeedbackWriterName = "Lili Horinca",
                 Feedback = "Totul a fost bine",
                 FeedbackWriterEmail = "c@c.com",
             },
             new FeedBack
             {
                 Id = 4,
                 TeachedCourseId = 2,
                 FeedbackWriterName = "Bogdan Sava",
                 Feedback = "Nu totul a fost bine",
                 FeedbackWriterEmail = "d@d.com",
             },
             new FeedBack
             {
                 Id = 5,
                 TeachedCourseId = 3,
                 FeedbackWriterName = "Ioana Constatin",
                 Feedback = "Nu totul a fost bine",
                 FeedbackWriterEmail = "c@c.com",
             }
               );
        }


    }
}
