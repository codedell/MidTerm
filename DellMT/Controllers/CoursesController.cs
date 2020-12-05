using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DellMT.Models;
using DellMT.ViewModels;

namespace DellMT.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext _context;
        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var courses = _context.Courses.ToList();

            return View(courses);
        }

        /*
        public ViewResult Index()
        {
            var courses = _context.Courses.Include(c => c.CourseRating).ToList();

            return View(courses);
        }
        
        public ViewResult New()
        {
            var courseRatings = _context.CourseRatings.ToList();
            var viewModel = new CourseFromViewModel
            {
                CourseRatings = courseRatings
            };

            return View("CourseForm", viewModel);
        }
        */

        public ActionResult Details(int id)
        {
            var course = _context.Courses.SingleOrDefault(c => c.Id == id);

            if (course == null)
                return HttpNotFound();

            return View(course);
        }
        
    }
}