using Microsoft.EntityFrameworkCore;
using Nurse_IQ.Data;
using Nurse_IQ.Models;

namespace Nurse_IQ.Repoitory
{
    public class AnnouncementRepository : Repository<Announcement>, IAnnouncementRepository
    {
        private readonly AppDbContext Context;
        public AnnouncementRepository(AppDbContext _Context):base(_Context) 
        {
            Context = _Context;
        }

        public async Task<(List<Announcement>, int totalCount)> GetPagedAsync(string search, Category? category, int page, int pageSize)
        {
            //get the datafrom database and put in a list of type querable
            var query = Context.announcements
                .Include(a => a.CreatedBy)
                .AsQueryable();

            // check if the user search
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(a => a.Title.Contains(search) || a.Content.Contains(search));
            // check if the category checked by the user
            if (category.HasValue)
                query = query.Where(a => a.category == category.Value);
            //handle the pagination
            var totalCount = await query.CountAsync();
            var items = await query
                .OrderByDescending(a => a.Date)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (items, totalCount);
        }

        public async Task<Announcement?> GetByIdAsync(int id)
        {
            // just get the details of specific announcement from the database
            return await Context.announcements
                .Include(a => a.CreatedBy)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
