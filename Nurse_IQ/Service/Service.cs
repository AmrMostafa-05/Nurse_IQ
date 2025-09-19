using NuGet.Protocol.Core.Types;
using Nurse_IQ.Repoitory;
using Nurse_IQ.UnityOfWork;

namespace Nurse_IQ.Service
{
    // Assuming this is your base Service<T> class
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IRepository<T> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public  async Task<List<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public  async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public  async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            await _unitOfWork.SaveAsync();
        }
    }

}
