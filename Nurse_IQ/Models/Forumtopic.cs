namespace Nurse_IQ.Models
{
    public class Forumtopic
    {
        public int Id { get; set; }
        //public string UserName { get; set; }//link with user get from User (using either select projection or eager loading)
        public string Title { get; set; }
        public string Description { get; set; }

        public string category { get; set; }

        public List<string> comments { get; set; }
        public int num_comments => comments.Count;
        public int num_of_likes { get; set; }
        public int num_of_views { get; set; }

        public int UserId { get; set; }
        public applicationUser User { get; set; }

    }
}
