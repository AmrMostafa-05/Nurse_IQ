using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Models;
using Nurse_IQ.Service;

namespace Nurse_IQ.Controllers
{
    public class MedicalTermController : Controller
    {
        private readonly IMedicalTermService _service;

        public MedicalTermController(IMedicalTermService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _service.GetDistinctCategoriesAsync();
            return View(categories);
        }

        public async Task<IActionResult> GetTerms(string search, Enums.MedicalTerm.Category? category, int page = 1, string letter = null)
        {
            var (terms, currentPage, totalPages) = await _service.GetTermsAsync(search, category, page, letter);
            return PartialView("_MedicalTermList", (terms, currentPage, totalPages));
        }

        public async Task<IActionResult> Details(int id)
        {
            var term = await _service.GetWithCreatedByAsync(id);
            if (term == null) return NotFound();
            return PartialView("_MedicalTermDetails", term);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MedicalTerm term)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _service.AddAsync(term);
            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {
            return PartialView("_AddTermForm", new MedicalTerm());
        }

        public IActionResult AdvancedSearchForm()
        {
            return PartialView("_AdvancedSearch");
        }

        public async Task<IActionResult> GetDictionaryStats()
        {
            var stats = await _service.GetDictionaryStatsAsync();
            return Json(new { TotalTerms = stats.TotalTerms, TotalCategories = stats.TotalCategories, TotalLanguages = stats.TotalLanguages, NewTerms = stats.NewTerms });
        }
    }
}
