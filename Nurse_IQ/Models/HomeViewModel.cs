using Nurse_IQ.Models;

namespace Nurse_IQ.Models
{
    public class HomeViewModel
    {
        public int CoursesCount { get; set; }
        public int UsersCount { get; set; }
        public int TrainingsCount { get; set; }
        public int ArticlesCount { get; set; }
        public List<Article> LatestArticles { get; set; } = new List<Article>();
        public List<Announcement> LatestAnnouncements { get; set; } = new List<Announcement>();
        public List<Training> LatestTrainings { get; set; } = new List<Training>();
    }
}
