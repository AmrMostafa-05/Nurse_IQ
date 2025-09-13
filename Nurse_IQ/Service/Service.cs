using Nurse_IQ.Repoitory;
using Nurse_IQ.UnityOfWork;

namespace Nurse_IQ.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public List <T> GetAll() => _repository.GetAll();

        public T GetById(int id) => _repository.GetById(id);

        public void Add(T entity)
        {
            _repository.Add(entity);
            _unitOfWork.Save();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _unitOfWork.Save();
        }
    }

}
