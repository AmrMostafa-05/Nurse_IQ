using Nurse_IQ.Models;
using Nurse_IQ.Repoitory;
using Nurse_IQ.UnityOfWork;

namespace Nurse_IQ.Service
{
    public class LectureService : Service<Lecture>, ILectureService
    {
        private readonly ILectureRepository LectRepo;
        public LectureService(ILectureRepository lectureRepository,IUnitOfWork unitOfWork)
            : base(lectureRepository, unitOfWork)
        {
            LectRepo = lectureRepository;
        }
        public async Task<Lecture?> GetLectureWithDetails(int id)
        {
           return await LectRepo.GetLectureWithDetails(id);
        }
    }
}
