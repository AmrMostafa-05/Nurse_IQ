using Microsoft.AspNetCore.Mvc;

namespace Nurse_IQ.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
