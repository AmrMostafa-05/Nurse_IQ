using Nurse_IQ.Models;

namespace Nurse_IQ.Repoitory
{
    public interface IDiplomaRepository : IRepository<Diploma>
    {

        public Task<List<Diploma>> GetAllWithFeatures();
        public Task<Diploma?> GetByIdWithFeatures(int id);
    }
}
