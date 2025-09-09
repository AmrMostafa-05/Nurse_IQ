namespace Nurse_IQ.Models
{
    public class UserRegisteredTraining
    {
       // public string Status { get; set; } // Registered, Completed, Cancelled

        // FKs
        public int UserId { get; set; }
        public applicationUser User { get; set; }

        public int TrainingId { get; set; }
        public Training Training { get; set; }
    }

}
