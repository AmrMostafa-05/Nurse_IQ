using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Service;

namespace Nurse_IQ.Controllers
{
    public class DiplomaController : Controller
    {
        private readonly IDiplomaService diplomaService;

        public DiplomaController(IDiplomaService diplomaService)
        {
            this.diplomaService = diplomaService;
        }
        public async Task<IActionResult> Index()
        {
            var diplomas = await diplomaService.GetAllWithFeatures();
            return View(diplomas);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var diploma = await diplomaService.GetByIdWithFeatures(id);
            if (diploma == null) return NotFound();
            return PartialView("_DiplomaModal", diploma);
        }
    }
}
