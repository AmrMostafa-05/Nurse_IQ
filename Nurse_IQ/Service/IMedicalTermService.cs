using Nurse_IQ.Models;

namespace Nurse_IQ.Service
{
    public interface IMedicalTermService:IService<MedicalTerm>
    {

        Task<(List<MedicalTerm>, int, int)> GetTermsAsync(string search, Enums.MedicalTerm.Category? category, int page, string letter = null);
        Task<MedicalTerm?> GetWithCreatedByAsync(int id);
        Task<(int TotalTerms, int TotalCategories, int TotalLanguages, int NewTerms)> GetDictionaryStatsAsync();
        Task<List<Enums.MedicalTerm.Category>> GetDistinctCategoriesAsync(); // New: Expose categories
    }
}
