using Microsoft.EntityFrameworkCore;
using Nurse_IQ.Data;
using Nurse_IQ.Models;
using System.Diagnostics.Metrics;

namespace Nurse_IQ.Repoitory
{
    public class MedicalTermRepository : Repository<MedicalTerm>, IMedicalTermRepository
    {
        private readonly AppDbContext Context;

        public MedicalTermRepository(AppDbContext _context) : base(_context) 
        {
            Context = _context;
        }
        public async Task<(List<MedicalTerm>, int)> GetTermsAsync
            (string search, Enums.MedicalTerm.Category? category, int page, int pageSize, string letter = null)
        {
            var query = Context.medicalTerms.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(t =>
                    t.arabicName.Contains(search) ||
                    t.englishName.Contains(search) ||
                    t.latinName.Contains(search));
            }

            if (category.HasValue)
            {
                query = query.Where(t => t.category.Equals(category.Value));
            }

            if (!string.IsNullOrWhiteSpace(letter))
            {
                query = query.Where(t => t.arabicName.StartsWith(letter) || t.englishName.StartsWith(letter) || t.latinName.StartsWith(letter));
                query = query.Where(t => t.category.Equals(category.Value));
            }

            var total = await query.CountAsync();

            var terms = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (terms, total);
        }

        public async Task<MedicalTerm?> GetWithCreatedByAsync(int id)
        {
            return await Context.medicalTerms
                .Include(t => t.User)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<int> GetTotalCountAsync()
        {
            return await Context.medicalTerms.CountAsync();
        }
        public async Task<List<Enums.MedicalTerm.Category>> GetDistinctCategoriesAsync()
        {
            return await Context.medicalTerms
                .Select(t => (Enums.MedicalTerm.Category)t.category)
                .Distinct()
                .ToListAsync();
        }

    }
}
