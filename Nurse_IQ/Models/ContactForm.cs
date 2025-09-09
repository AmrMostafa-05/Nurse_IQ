using Nurse_IQ.Enums.ContactForm;

namespace Nurse_IQ.Models
{
    public class ContactForm
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public InquiryType InquiryType { get; set; }
        public string message { get; set; }
        public int AdminId { get; set; }
        public Admin admin { get; set; }

    }
}
