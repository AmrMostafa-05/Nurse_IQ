using Nurse_IQ.Models;
using Nurse_IQ.Enums.MedicalTerm;
namespace Nurse_IQ.Repoitory
{
    public interface IMedicalTermRepository:IRepository<MedicalTerm>
    {
        Task<(List<MedicalTerm>, int)> GetTermsAsync(string search, Enums.MedicalTerm.Category? category, int page, int pageSize, string letter = null);
        Task<MedicalTerm?> GetWithCreatedByAsync(int id);
        Task<int> GetTotalCountAsync(); // For stats
        Task<List<Enums.MedicalTerm.Category>> GetDistinctCategoriesAsync(); 

    }
}
