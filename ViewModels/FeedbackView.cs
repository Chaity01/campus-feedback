
namespace CampusFeedback.ViewModels
{
    public class FeedbackView
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string UniversityId { get; set; }
        public string Email { get; set; }
        public string QuestionTitle { get; set; }
        public string Value { get; set; }
        public string ValueString { get; set; }
    }
}
