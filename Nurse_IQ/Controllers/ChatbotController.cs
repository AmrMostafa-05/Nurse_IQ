using Microsoft.AspNetCore.Mvc;

namespace Nurse_IQ.Controllers
{
    public class ChatbotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
