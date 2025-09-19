using Nurse_IQ.Models;

namespace Nurse_IQ.Service
{
    public interface ILectureService : IService<Lecture>
    {
        public Task<Lecture?> GetLectureWithDetails(int id);

    }
}
