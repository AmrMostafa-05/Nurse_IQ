using Nurse_IQ.Enums.Course;
using Nurse_IQ.Models;
using Nurse_IQ.Repoitory;
using Nurse_IQ.UnityOfWork;

namespace Nurse_IQ.Service
{
    public class CourseService : Service<Course>, ICourseService
    {

        private readonly ICourseRepository _courseRepo;

        public CourseService(ICourseRepository courseRepo, IUnitOfWork unitOfWork)
            : base(courseRepo, unitOfWork)
        {
            _courseRepo = courseRepo;
        }

        public List<Course> FilterByYearLevelSemesterType(
            CourseYearLevel yearLevel,
            CourseSemester semester,
            CourseType type)
        {
            return _courseRepo.FilterByYearLevelSemesterType(yearLevel, semester, type);
        }

    }
}
