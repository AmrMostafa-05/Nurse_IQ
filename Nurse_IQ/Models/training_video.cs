namespace Nurse_IQ.Models
{
    public class training_video
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string category { get; set; }//would be enum after we get the data 

            public string publishedDate { get; set; }
            public string duration { get; set; }

            public string thumbnailUrl{ get; set; }
            public string instructorName { get; set; }
            public string instructorImage { get; set; }
            public string videoUrl { get; set; }
            public int numberOfViews { get; set; }// we have to compute it

            public int AdminId { get; set; }
            public Admin AddedBy { get; set; }



    }
}
