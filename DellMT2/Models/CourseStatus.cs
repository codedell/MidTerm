using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DellMT2.Models
{
    public class CourseStatus
    {
        [Display(Name = "Course Id")]
        public int Id { get; set; }

        [StringLength(30)]
        [Display(Name = "Course Status")]
        public string Status { get; set; }
    }
}