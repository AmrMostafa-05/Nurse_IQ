namespace Nurse_IQ.Models
{
    public class 
        DiplomaFeature
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public string Icon { get; set; }

        public int DiplomaId { get; set; } 
        public Diploma Diploma { get; set; }
    }
}
