using Nurse_IQ.Enums.Course;
using Nurse_IQ.Models;

namespace Nurse_IQ.Repoitory
{
    public interface ICourseRepository : IRepository<Course>
    {
        public List<Course> FilterByYearLevelSemesterType(CourseYearLevel yearLevel,
            CourseSemester semester,
            CourseType type);
       
    }
}
