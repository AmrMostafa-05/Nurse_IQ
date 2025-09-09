namespace Nurse_IQ.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public string category { get; set; }

        public string autorImage { get; set; } // we would get it as static cuz author table doesn't have image
        public string publisheDate { get; set; }
        public string readTime { get; set; }
        public int Num_of_views { get; set; }

        public int UserId { get; set; }//as an author(doctor) 
        public User User { get; set; }

        public int AdminId { get; set; }//the admins add here 
        public Admin AddedBy { get; set; }




    }
}
