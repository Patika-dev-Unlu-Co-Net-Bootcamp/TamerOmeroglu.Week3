using System.ComponentModel.DataAnnotations;

namespace PatikaDevCodeFirst.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Detail { get; set; }

        [Required]
        public int DurationWeek { get; set; }
    }
}
