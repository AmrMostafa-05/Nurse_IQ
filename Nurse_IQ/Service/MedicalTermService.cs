using NuGet.Protocol.Core.Types;
using Nurse_IQ.Models;
using Nurse_IQ.Repoitory;
using Nurse_IQ.UnityOfWork;

namespace Nurse_IQ.Service
{
    public class MedicalTermService : Service<MedicalTerm>, IMedicalTermService
    {

        private readonly IMedicalTermRepository medicalTermRepo;
        private readonly IUnitOfWork unitOfWork;
        private readonly int _pageSize;
        public MedicalTermService(IMedicalTermRepository medicalTermRepo ,IUnitOfWork unitOfWork, IConfiguration config)
            :base(medicalTermRepo,unitOfWork) 
        {
            this.medicalTermRepo = medicalTermRepo;
            this.unitOfWork = unitOfWork;
            _pageSize = config.GetValue<int>("Dictionary:PageSize", 6); // default 6
        }

        //public void AddMedicalTerm(MedicalTerm term)
        //{
        //    medicalTermRepo.Add(term);
        //    unitOfWork.Save();
        //}
        public async Task<(List<MedicalTerm>, int, int)> GetTermsAsync(string search, Enums.MedicalTerm.Category? category, int page, string letter = null)
        {
            var (terms, totalCount) = await medicalTermRepo.GetTermsAsync(search, category, page, _pageSize, letter);
            int totalPages = (int)Math.Ceiling((double)totalCount / _pageSize);
            return (terms, page, totalPages);
        }

        public async Task<MedicalTerm?> GetWithCreatedByAsync(int id)
        {
            return await medicalTermRepo.GetWithCreatedByAsync(id);
        }

        public async Task<(int TotalTerms, int TotalCategories, int TotalLanguages, int NewTerms)> GetDictionaryStatsAsync()
        {
            int totalTerms = await medicalTermRepo.GetTotalCountAsync();
            int totalCategories = Enum.GetValues(typeof(Enums.MedicalTerm.Category)).Length;
            int totalLanguages = 3; // Arabic, English, Latin
            int newTerms = 0; // Placeholder; no CreatedAt
            return (totalTerms, totalCategories, totalLanguages, newTerms);
        }
        public async Task<List<Enums.MedicalTerm.Category>> GetDistinctCategoriesAsync()
        {
            return await medicalTermRepo.GetDistinctCategoriesAsync();
        }

    }
}
