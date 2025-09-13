using Nurse_IQ.Enums.Course;
using Nurse_IQ.Models;

namespace Nurse_IQ.Service
{
    public interface ICourseService : IService<Course>
    {
        public List<Course> FilterByYearLevelSemesterType(CourseYearLevel yearLevel, CourseSemester semester, CourseType type);
    }
}
