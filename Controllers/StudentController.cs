﻿using MyElearning.DataAccess.Context;
using MyElearning.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearning.Controllers
{
    public class StudentController : Controller
    {
        ElearningContext context = new ElearningContext();
        public ActionResult Index()
        {
            var values = context.Students.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            var value = context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteStudent(int id)
        {
            var value = context.Students.Find(id);
            context.Students.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            var value = context.Students.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        {
            var value=context.Students.Find(student.StudentId);
            value.Name=student.Name;
            value.Surname=student.Surname;
            value.Email=student.Email;
            value.Password=student.Password;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}