using Nurse_IQ.Enums.Question;

namespace Nurse_IQ.Models
{
    public class Question
    {
        public int Id { get; set; }
        public hardnessType hardnessType { get; set; } 
        public string Text { get; set; }
        //added
        public string CorrectAnswer { get; set; }
        public string Student_Answer { get; set; } 
        public bool IsCorrect { get; set; }
        public List<string> options { get; set; }


        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        //public List<Answer> Answers { get; set; }
    }

}
