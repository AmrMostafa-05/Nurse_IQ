using Microsoft.EntityFrameworkCore;
using Nurse_IQ.Data;
using Nurse_IQ.Models;

namespace Nurse_IQ.Repoitory
{
    public class LectureRepository : Repository<Lecture>, ILectureRepository
    {
        private readonly AppDbContext Context;
        public LectureRepository(AppDbContext _Context):base(_Context)
        {
            Context=_Context;
        }
        public async Task<Lecture?> GetLectureWithDetails(int id)
        {
            return await Context.lectures
                .Include(l => l.Course)
                .Include(l => l.Materials)
                .Include(l => l.Quiz)
                .FirstOrDefaultAsync(l => l.Id == id);
        }
    }
}
