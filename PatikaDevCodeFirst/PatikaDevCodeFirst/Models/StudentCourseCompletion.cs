namespace PatikaDevCodeFirst.Models
{
    public class StudentCourseCompletion
    {
        public int Id { get; set; }
        public int CourseStudentId { get; set; }
        public CourseStudent CourseStudent { get; set; }
        public int TotalWeekAttended { get; set; }
    }
}
