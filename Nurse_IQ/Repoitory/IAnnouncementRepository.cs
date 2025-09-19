using Nurse_IQ.Models;

namespace Nurse_IQ.Repoitory
{
    public interface IAnnouncementRepository:IRepository<Announcement>
    {
        Task<(List<Announcement>, int totalCount)> GetPagedAsync(string search, Category? category, int page, int pageSize);
        Task<Announcement?> GetByIdAsync(int id);
    }
}
