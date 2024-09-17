
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseVM> GetCourses();
    }
}
