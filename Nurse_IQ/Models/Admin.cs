
namespace Nurse_IQ.Models
{
    public class Admin
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public List<Course> Courses { get; set; }
        public List<Lecture> Lectures { get; set; }
        public List<Quiz> Quizes { get; set; }
        public List<Announcement> Announcements { get; set; } 
        public List<Training> Trainings { get; set; }
        public List<training_video> training_videos { get; set; }
        public List<Article> Articles { get; set; }
        public List<Offer> Offers { get; set; }
        public List<ContactForm> contactForms { get; set; }
        public List<MedicalTerm> medicalTerms { get; set; }
        public List<Medicine> medicines { get; set; }
        public List<Forumtopic> forumtopics { get; set; }
        public List<Diploma> diplomas { get; set; }



    }
}
