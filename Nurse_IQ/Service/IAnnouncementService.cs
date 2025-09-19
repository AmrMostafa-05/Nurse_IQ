using Nurse_IQ.Models;

namespace Nurse_IQ.Service
{
    public interface IAnnouncementService:IService<Announcement>
    {
         Task<(List<Announcement> Announcements, int CurrentPage, int TotalPages)>
            GetAnnouncementsAsync(string search, Category? category, int page, int pageSize);

         Task<Announcement?> GetAnnouncementByIdAsync(int id);
    }

}
