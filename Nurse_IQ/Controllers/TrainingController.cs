using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Data;
using Nurse_IQ.Models;

namespace Nurse_IQ.Controllers
{
    [Authorize]
    public class TrainingController : Controller
    {
        // Simulated database context using SeedData
        private static readonly List<training_video> _videos = SeedData.TrainingVideos.ToList();
        private static readonly List<Training> _trainings = SeedData.Trainings.ToList();

        // GET: /Training
        [AllowAnonymous]
        public IActionResult Index(string? category = null, string? search = null)
        {
            var videosQuery = _videos.AsQueryable();
            var trainingsQuery = _trainings.AsQueryable();

            // Filter by category
            if (!string.IsNullOrEmpty(category) && category != "all")
            {
                videosQuery = videosQuery.Where(v => v.category == category);
                trainingsQuery = trainingsQuery.Where(t => t.Category == category);
            }

            // Search
            if (!string.IsNullOrEmpty(search))
            {
                videosQuery = videosQuery.Where(v =>
                    v.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    v.Description.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    v.category.Contains(search, StringComparison.OrdinalIgnoreCase));

                trainingsQuery = trainingsQuery.Where(t =>
                    t.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    t.Description.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    t.Category.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            var model = new TrainingViewModel
            {
                Videos = videosQuery.OrderByDescending(v => v.publishedDate).ToList(),
                Trainings = trainingsQuery.OrderByDescending(t => t.postedDate).ToList()
            };

            // Pass categories for filter dropdown
            ViewBag.Categories = _videos.Select(v => v.category)
                .Union(_trainings.Select(t => t.Category))
                .Distinct()
                .ToList();

            ViewBag.CurrentCategory = category;
            ViewBag.SearchTerm = search;

            return View(model);
        }

        // GET: Video/{id}
        [AllowAnonymous]
        public IActionResult VideoDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var video = _videos.FirstOrDefault(v => v.Id == id);
            if (video == null)
            {
                return NotFound();
            }

            return View(video);
        }

        // GET: Job/{id}
        [AllowAnonymous]
        public IActionResult JobDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var training = _trainings.FirstOrDefault(t => t.Id == id);
            if (training == null)
            {
                return NotFound();
            }

            return View(training);
        }

        // GET: Apply/{id}
        [Authorize(Roles = "Student,Excellence_student,graduate")]
        public IActionResult Apply(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var training = _trainings.FirstOrDefault(t => t.Id == id);
            if (training == null)
            {
                return NotFound();
            }

            var model = new ApplicationViewModel
            {
                TrainingId = id.Value,
                TrainingTitle = training.Title
            };

            return View(model);
        }

        // POST:Apply
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Student,Excellence_student,graduate")]
        public IActionResult Apply(ApplicationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Simulate saving application (in production, save to database)
            TempData["SuccessMessage"] = "تم إرسال طلبك بنجاح! سنتواصل معك قريباً";
            return RedirectToAction(nameof(Index));
        }

        // AJAX: Get videos by category
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetVideosByCategory(string category)
        {
            var videos = _videos
                .Where(v => v.category == category)
                .OrderByDescending(v => v.publishedDate)
                .Take(6)
                .ToList();

            return PartialView("_VideosPartial", videos);
        }

        // AJAX: Get trainings by category
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetTrainingsByCategory(string category)
        {
            var trainings = _trainings
                .Where(t => t.Category == category)
                .OrderByDescending(t => t.postedDate)
                .Take(6)
                .ToList();

            return PartialView("_TrainingsPartial", trainings);
        }

        // AJAX: Search videos and trainings
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Search(string term)
        {
            var videos = _videos
                .Where(v => v.Title.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                           v.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(v => v.publishedDate)
                .Take(5)
                .ToList();

            var trainings = _trainings
                .Where(t => t.Title.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                           t.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(t => t.postedDate)
                .Take(5)
                .ToList();

            var model = new TrainingViewModel
            {
                Videos = videos,
                Trainings = trainings
            };

            return PartialView("_SearchResultsPartial", model);
        }
    }

    // ViewModel for Index page
    public class TrainingViewModel
    {
        public List<training_video> Videos { get; set; }
        public List<Training> Trainings { get; set; }
    }

    // ViewModel for Application form
    public class ApplicationViewModel
    {
        public int TrainingId { get; set; }
        public string TrainingTitle { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantPhone { get; set; }
        public string ApplicantUniversity { get; set; }
        public string ApplicantYear { get; set; }
        public decimal ApplicantGPA { get; set; }
        public string ApplicantExperience { get; set; }
        public string ApplicantMotivation { get; set; }
    }
}