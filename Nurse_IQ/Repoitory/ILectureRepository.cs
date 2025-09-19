using Nurse_IQ.Models;

namespace Nurse_IQ.Repoitory
{
    public interface ILectureRepository : IRepository<Lecture>
    {
        public Task<Lecture?>  GetLectureWithDetails(int id);
    }
}
