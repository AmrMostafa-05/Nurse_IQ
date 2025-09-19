namespace Nurse_IQ.Models
{
    public class MedicalTerm
    {
        public int Id { get; set; }
        public string arabicName { get; set; }
        public string englishName { get; set; }
        public string latinName { get; set; }
        public string definition { get; set; }
        public Category category { get; set; }
        public string example { get; set; }
        public List<string> synonyms { get; set; }


        public int UserId { get; set; }
        public applicationUser User { get; set; }
    }
}
