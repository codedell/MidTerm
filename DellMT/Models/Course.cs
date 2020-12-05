using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DellMT.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Tutor Name")]
        public string TutorName { get; set; }

        [Display(Name = "Course Rating")]
        public int CourseRating { get; set; }

        public List<Student> Students { get; set; }
    }
}