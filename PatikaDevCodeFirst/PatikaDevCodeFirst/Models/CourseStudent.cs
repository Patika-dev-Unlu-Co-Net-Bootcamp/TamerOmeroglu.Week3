namespace PatikaDevCodeFirst.Models
{
    public class CourseStudent
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public decimal GradeRate { get; set; }
    }
}
