using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearning.DataAccess.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public virtual Category category { get; set; }

        public int InstructorId { get; set; }
        public virtual Instructor ınstructor { get; set; }

        public List<CourseRegister> CourseRegisters { get; set; }
    }
}