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
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CourseName { get; set; }

        [Required]
        [StringLength(255)]
        public string CourseDescription { get; set; }

        [Required]
        [StringLength(61)]
        public string TutorName { get; set; }

        [Required]
        [Range(1,10)]
        public int CourseRating { get; set; }
    }
}