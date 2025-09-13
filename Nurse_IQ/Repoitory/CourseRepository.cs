
using Nurse_IQ.Data;
using Nurse_IQ.Enums.Course;
using Nurse_IQ.Models;

namespace Nurse_IQ.Repoitory
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly AppDbContext Context;

        public CourseRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }


        public List<Course> FilterByYearLevelSemesterType(CourseYearLevel yearLevel,CourseSemester semester,CourseType type)
        {
            return Context.Courses
                          .Where(c => c.YearLevel == yearLevel && c.semister == semester && c.courseType == type)
                          .ToList();
        }

    }
}
