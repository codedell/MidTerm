using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DellMT2.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Course Id")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        public DateTime CourseEnrolledDate { get; set; }

        [Required]
        [Display(Name = "Course Status")]
        public int CourseStatus { get; set; }

        [Required]
        [StringLength(2)]
        public string Grade { get; set; }
    }
}