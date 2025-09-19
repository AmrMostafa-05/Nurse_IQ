using Nurse_IQ.Enums.Announcement;

namespace Nurse_IQ.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Category category { get; set; }
        
        public string AdminImageUrl { get; set; }


        public int CreatedByAdminId { get; set; }
        public applicationUser CreatedBy { get; set; }

    }
}
