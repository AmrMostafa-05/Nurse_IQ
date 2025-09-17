namespace Nurse_IQ.Models
{
    public class MedicineViewModel
    {
        public int Id { get; set; }
        public string arabicName { get; set; }
        public string englishName { get; set; }
        public string latinName { get; set; }
        public string category { get; set; }
        public string form { get; set; }
        public string description { get; set; }
        public string indications { get; set; }
        public string sideEffects { get; set; }
        public string dosage { get; set; }
        public string UserName { get; set; }
    }
}