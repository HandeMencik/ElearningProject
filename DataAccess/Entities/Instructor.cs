﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearning.DataAccess.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public List<Course> Courses { get; set; }
    }
}