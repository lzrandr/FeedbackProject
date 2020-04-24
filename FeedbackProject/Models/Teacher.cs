﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackProject.Models
{
    public class Teacher : IPerson
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}