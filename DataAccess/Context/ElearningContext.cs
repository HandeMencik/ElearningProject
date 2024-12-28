using MyElearning.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyElearning.DataAccess.Context
{
    public class ElearningContext : DbContext
    {
        //Vs da bulunan entitiyler için db kısmında tablo oluşturma işlemi 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }     
        public DbSet<CourseRegister> courseRegisters { get; set; }
        public DbSet<About> Abouts { get; set; }

    }
}