namespace Nurse_IQ.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public List<Question> Questions { get; set; }

        //updated 
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }

        public int UserId { get; set; }
        public applicationUser User { get; set; }


    }
}