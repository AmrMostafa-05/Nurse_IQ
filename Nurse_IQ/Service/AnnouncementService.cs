using Nurse_IQ.Models;
using Nurse_IQ.Repoitory;
using Nurse_IQ.UnityOfWork;

namespace Nurse_IQ.Service
{
    public class AnnouncementService : Service<Announcement>, IAnnouncementService
    {
        private readonly IAnnouncementRepository announcementRepo;
        private readonly int _pageSize;

        public AnnouncementService
            (IAnnouncementRepository _AnnouncementRepo, IUnitOfWork unitOfWorkUnityOfWork, IConfiguration config)
            :base(_AnnouncementRepo,unitOfWorkUnityOfWork)   
        {
            announcementRepo = _AnnouncementRepo;
            _pageSize= config.GetValue<int>("Announcements:PageSize", 6); // 6 قيمة افتراضية 
        }
        public async Task<(List<Announcement> Announcements, int CurrentPage, int TotalPages)>
        GetAnnouncementsAsync(string search, Category? category, int page, int pageSize)
        {
            var (items, totalCount) = await announcementRepo.GetPagedAsync(search, category, page, pageSize);

            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            return (items, page, totalPages);
        }

        public async Task<Announcement?> GetAnnouncementByIdAsync(int id)
        {
            return await announcementRepo.GetByIdAsync(id);
        }

    }
}
