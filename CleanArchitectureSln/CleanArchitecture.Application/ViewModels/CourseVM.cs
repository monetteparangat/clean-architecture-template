using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.ViewModels
{
    public class CourseVM
    {
        public IEnumerable<Course> Courses {  get; set; }
    }
}
