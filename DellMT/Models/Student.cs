using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DellMT.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(125)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [StringLength(125)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Select Course")]
        public int CourseId { get; set; }

        public DateTime? EnrolledDate { get; set; }

        public int CourseStatus { get; set; }

        public string Grade { get; set; }

        public Course Course { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime Birthdate { get; set; }
    }
}