namespace PatikaDevCodeFirst.Models
{
    public class CourseParticipant
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int ParticipantId { get; set; }
        public Participant Participant { get; set; }
    }
}
