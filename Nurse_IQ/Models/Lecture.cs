namespace Nurse_IQ.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string smallDescription { get; set; }
        public string bigDescription { get; set; }
        public string duration { get; set; }
        public string videoUrl { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public Quiz? Quiz { get; set; }
        public List<LectureMaterial> Materials { get; set; }
        public int AdminId { get; set; }
        public Admin AddedBy { get; set; }

    }
}