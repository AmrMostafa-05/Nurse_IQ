namespace Nurse_IQ.UnityOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        Task<int> SaveAsync();
    }
}
