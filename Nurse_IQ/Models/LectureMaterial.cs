namespace Nurse_IQ.Models
{
    public class LectureMaterial
    { // create LectureMaterial table has (FileName,FileUrl) and has 1 to m relation with Lecture
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public int LectureId { get; set; }
        public Lecture lecture { get; set; }
    }
}
