namespace Nurse_IQ.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public string category { get; set; }
        
        public string AdminImageUrl { get; set; }


        // FKs
        public int CreatedByAdminId { get; set; }
        public Admin CreatedBy { get; set; }

    }
}
