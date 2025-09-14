namespace Nurse_IQ.Repoitory
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        Task<int> CountAsync();
        void Save();
    }
}
