using DellMT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DellMT.ViewModels
{
    public class StudentFormViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public Student Student { get; set; }
    }
}