using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DellMT.Models;
using DellMT.ViewModels;

namespace DellMT.Controllers
{
    public class StudentsController : Controller
    {
        private ApplicationDbContext _context;

        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var courses = _context.Courses.ToList();
            var viewModel = new StudentFormViewModel
            {
                Courses = courses
            };
            return View("StudentForm", viewModel);
        }
        [HttpPost]
        public ActionResult Save(Student student)
        {
            if (student.Id == 0)
                _context.Students.Add(student);
            
            else
            {
                var studentInDb = _context.Students.Single(s => s.Id == student.Id);
                studentInDb.FirstName = student.FirstName;
                studentInDb.Birthdate = student.Birthdate;
                studentInDb.LastName = student.LastName;
                studentInDb.CourseId = student.CourseId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Students");
        }

        public ViewResult Index()
        {
            var students = _context.Students.Include(s => s.Course).ToList();

            return View(students);
        }

        public ActionResult Details(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);

            if (student == null)
                return HttpNotFound();

            return View(student);
        }

        public ActionResult Edit(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);
            if (student == null)
                return HttpNotFound();

            var viewModel = new StudentFormViewModel
            {
                Student = student,
                Courses = _context.Courses.ToList()
            };
            return View("StudentForm", viewModel);
        }
    }
}