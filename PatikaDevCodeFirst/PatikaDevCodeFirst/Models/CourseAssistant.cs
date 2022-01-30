namespace PatikaDevCodeFirst.Models
{
    public class CourseAssistant
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int AssistantId { get; set; }
        public Assistant Assistant { get; set; }
    }
}
