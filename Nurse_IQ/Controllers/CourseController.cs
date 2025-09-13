using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Service;

namespace Nurse_IQ.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService) 
        {
            this.courseService = courseService;
        }
        public IActionResult Index()//get all and when he press the filters goes to 
        {
            var courses =courseService.GetAll();
            return View(courses);
        }
        [HttpGet]
        public IActionResult FilteredCourses(CourseYearLevel yearLevel, CourseSemester semester, CourseType type)
        {
            var courses = courseService.FilterByYearLevelSemesterType(yearLevel, semester, type);
            return View("Index", courses);
        }

    }
}
