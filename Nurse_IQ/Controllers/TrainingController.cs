using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Models;
using Nurse_IQ.UnityOfWork;

namespace Nurse_IQ.Controllers
{
    public class TrainingController : Controller
    {
        private readonly ILogger<TrainingController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public TrainingController(ILogger<TrainingController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                // جلب جميع التدريبات
                var trainings = await _unitOfWork.trainings.GetAllAsync();
                
                // جلب جميع الفيديوهات التدريبية
                var trainingVideos = await _unitOfWork.training_Videos.GetAllAsync();

                // إنشاء ViewModel للصفحة
                var trainingViewModel = new TrainingViewModel
                {
                    Trainings = trainings.ToList(),
                    TrainingVideos = trainingVideos.ToList()
                };

                return View(trainingViewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading training page data");
                return View(new TrainingViewModel());
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var training = await _unitOfWork.trainings.GetByIdAsync(id);
                if (training == null)
                {
                    return NotFound();
                }

                return View(training);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading training details for ID: {Id}", id);
                return NotFound();
            }
        }

        public async Task<IActionResult> VideoDetails(int id)
        {
            try
            {
                var video = await _unitOfWork.training_Videos.GetByIdAsync(id);
                if (video == null)
                {
                    return NotFound();
                }

                return View(video);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading training video details for ID: {Id}", id);
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> ApplyForTraining(int trainingId, string applicantName, string applicantEmail, string applicantPhone, string applicantUniversity, string applicantYear, decimal applicantGPA, string applicantExperience, string applicantMotivation)
        {
            try
            {
                // هنا يمكن إضافة منطق التقديم للتدريب
                // مثل حفظ البيانات في قاعدة البيانات أو إرسال إيميل
                
                _logger.LogInformation("Application submitted for training {TrainingId} by {ApplicantName}", trainingId, applicantName);
                
                return Json(new { success = true, message = "تم إرسال طلبك بنجاح! سنتواصل معك قريباً" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error submitting training application");
                return Json(new { success = false, message = "حدث خطأ أثناء إرسال الطلب" });
            }
        }
    }
}
