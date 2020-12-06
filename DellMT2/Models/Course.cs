using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DellMT2.Models
{
    public class Course
    {
        [Required]
        [Display(Name = "Course Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Required]
        [StringLength(61)]
        [Display(Name = "Tutor Name")]
        public string TutorName { get; set; }

        [Required]
        [Range(1,10)]
        [Display(Name = "Course Rating")]
        public int CourseRating { get; set; }
    }
}