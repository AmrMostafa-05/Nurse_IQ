using Nurse_IQ.Enums.Course;

namespace Nurse_IQ.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public CourseYearLevel YearLevel { get; set; }//1...6 which is graduate 
        //updated
        public CourseType courseType { get; set; }//practical or theoritical
        public CourseSemester semister { get; set; } // first or second 
        // added
        public string Duration { get; set; }
        public string imageUrl { get; set; }    
        public string smallDescription { get; set; }
        public string bigDescription { get; set; }
        public List<string> courseTopics { get; set; }
        public List<string>? courseRequizetes { get; set; }

        public int UserId { get; set; }
        public applicationUser User { get; set; }
        public List<Lecture> Lectures { get; set; }
        public List<Quiz> Quizzes { get; set; }

    }
}
