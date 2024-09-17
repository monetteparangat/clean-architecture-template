using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.ViewModels
{
    public class CourseVM
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public string ImageUrl {  get; set; }
        public IEnumerable<Course> Courses {  get; set; }
    }
}
