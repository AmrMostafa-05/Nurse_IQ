using Nurse_IQ.Models;
using Nurse_IQ.Repoitory;
using Nurse_IQ.UnityOfWork;

namespace Nurse_IQ.Service
{
    public class DiplomaService : Service<Diploma>, IDiplomaService
    {
        private readonly IDiplomaRepository DiplomaRepo;
        public DiplomaService(IDiplomaRepository diplomaRepository,IUnitOfWork unitOfWork) 
            :base(diplomaRepository,unitOfWork) 
        {
            DiplomaRepo = diplomaRepository;
        }
        public async Task<List<Diploma>> GetAllWithFeatures()
        {
            return await DiplomaRepo.GetAllWithFeatures();
        }

        public async Task<Diploma?> GetByIdWithFeatures(int id)
        {
            return await DiplomaRepo.GetByIdWithFeatures(id);
        }
    }
}
