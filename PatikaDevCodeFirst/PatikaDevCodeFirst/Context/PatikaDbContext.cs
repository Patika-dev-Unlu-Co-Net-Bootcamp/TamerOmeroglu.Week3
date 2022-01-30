using Microsoft.EntityFrameworkCore;
using PatikaDevCodeFirst.Models;

namespace PatikaDevCodeFirst.Context
{
    public class PatikaDbContext : DbContext
    {
        public PatikaDbContext(DbContextOptions<PatikaDbContext> options) : base(options)
        {

        }

        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseAssistant> CourseAsistants { get; set; }
        public DbSet<CourseDate> CourseDates { get; set; }
        public DbSet<CourseParticipant> CourseParticipants { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourseCompletion> StudentCourseCompletions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
