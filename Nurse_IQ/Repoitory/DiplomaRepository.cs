using Microsoft.EntityFrameworkCore;
using Nurse_IQ.Data;
using Nurse_IQ.Models;

namespace Nurse_IQ.Repoitory
{
    public class DiplomaRepository : Repository<Diploma>, IDiplomaRepository
    {
        private readonly AppDbContext Context;
        public DiplomaRepository(AppDbContext _appDbContext) : base(_appDbContext) 
        {
            Context = _appDbContext;
        }
        public async Task<List<Diploma>> GetAllWithFeatures()
        {
            return await Context.diplomas
                .Include(d => d.features)
                .ToListAsync();
        }

        public async Task<Diploma?> GetByIdWithFeatures(int id)
        {
            return await Context.diplomas
                  .Include(d => d.features)
                  .FirstOrDefaultAsync(d => d.ID == id);
        }
    }
}
