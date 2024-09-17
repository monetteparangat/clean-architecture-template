
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
        CourseVM GetCourses();
        void Create(CourseVM course);
    }
}
