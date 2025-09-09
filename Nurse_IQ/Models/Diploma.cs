namespace Nurse_IQ.Models
{
    public class Diploma
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }

        public List<String> requirement { get; set; }
        public List<String> register_steps { get; set; }

        public List<DiplomaFeature> features { get; set; }
        public int CreatedByAdminId { get; set; }
        public applicationUser CreatedBy { get; set; }
    }
}
