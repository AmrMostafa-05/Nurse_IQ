namespace Nurse_IQ.Models
{
    public class Training
    {
        public int Id { get; set; }
        public string Title { get; set; }//updated
        public string HospitalName { get; set; }
        public string Location { get; set; }
        //updated
        public string Category { get; set; }

        public Decimal salary { get; set; }
        public String? Experience { get; set; }
        public List<string> requirement { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public DateTime postedDate { get; set; }
        public DateTime deadline { get; set; }

        public List<UserRegisteredTraining> UserRegisteredTrainings { get; set; }

        public int CreatedByAdminId { get; set; }
        public applicationUser CreatedBy { get; set; }
    }

}
