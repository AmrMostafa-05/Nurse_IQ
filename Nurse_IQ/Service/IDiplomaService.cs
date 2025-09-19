using Nurse_IQ.Models;

namespace Nurse_IQ.Service
{
    public interface IDiplomaService : IService<Diploma>
    {
        public Task<List<Diploma>> GetAllWithFeatures();
        public Task<Diploma?> GetByIdWithFeatures(int id);
    }
}
