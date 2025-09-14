using Nurse_IQ.Models;

namespace Nurse_IQ.Models
{
    public class TrainingViewModel
    {
        public List<Training> Trainings { get; set; } = new List<Training>();
        public List<training_video> TrainingVideos { get; set; } = new List<training_video>();
    }
}
