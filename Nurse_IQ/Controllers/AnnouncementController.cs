using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Service;

namespace Nurse_IQ.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _service;
        private const int PageSize = 6;

        public AnnouncementController(IAnnouncementService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            // to view the buttons of the filteration dynamically
            var categories = Enum.GetValues(typeof(Category)).Cast<Category>();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAnnouncements(string search, Category? category, int page = 1)
        {
            var (items, currentPage, totalPages) =
                await _service.GetAnnouncementsAsync(search, category, page, PageSize);

            return PartialView("_AnnouncementList", (items, currentPage, totalPages));
        }

        public async Task<IActionResult> Details(int id)
        {
            var announcement = await _service.GetAnnouncementByIdAsync(id);
            if (announcement == null)
                return NotFound();

            return PartialView("_DetailsPartial", announcement);
        }

    }
}
