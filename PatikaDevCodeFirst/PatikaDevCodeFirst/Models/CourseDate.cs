using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatikaDevCodeFirst.Models
{
    public class CourseDate
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Courses { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime StartDate { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime EndDate { get; set; }
    }
}
