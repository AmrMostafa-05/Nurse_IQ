using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Models;
using Nurse_IQ.UnityOfWork;
using System.Diagnostics;

namespace Nurse_IQ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SetLanguage(string culture, string returnUrl = null)
        {
            if (string.IsNullOrEmpty(culture)) culture = "en";
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return LocalRedirect(returnUrl);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                // جلب البيانات للإحصائيات
                var coursesCount = await _unitOfWork.Courses.CountAsync();
                var usersCount = await _unitOfWork.applicationUsers.CountAsync();
                var trainingsCount = await _unitOfWork.trainings.CountAsync();
                var articlesCount = await _unitOfWork.articles.CountAsync();

                // جلب أحدث المقالات
                var latestArticles = await _unitOfWork.articles.GetAllAsync();
                latestArticles = latestArticles.Take(3).ToList();

                // جلب أحدث الإعلانات
                var latestAnnouncements = await _unitOfWork.announcements.GetAllAsync();
                latestAnnouncements = latestAnnouncements.Take(3).ToList();

                // جلب أحدث التدريبات
                var latestTrainings = await _unitOfWork.trainings.GetAllAsync();
                latestTrainings = latestTrainings.Take(3).ToList();

                // إنشاء ViewModel للصفحة الرئيسية
                var homeViewModel = new HomeViewModel
                {
                    CoursesCount = coursesCount,
                    UsersCount = usersCount,
                    TrainingsCount = trainingsCount,
                    ArticlesCount = articlesCount,
                    LatestArticles = latestArticles.ToList(),
                    LatestAnnouncements = latestAnnouncements.ToList(),
                    LatestTrainings = latestTrainings.ToList()
                };

                return View(homeViewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading home page data");
                return View(new HomeViewModel());
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
