using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Service;

namespace Nurse_IQ.Controllers
{
    public class LectureController : Controller
    {
        private readonly ILectureService _service;

        public LectureController(ILectureService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var lecture = await _service.GetLectureWithDetails(id);
            if (lecture == null)
                return NotFound();
            return View(lecture);
        }
    }
}
