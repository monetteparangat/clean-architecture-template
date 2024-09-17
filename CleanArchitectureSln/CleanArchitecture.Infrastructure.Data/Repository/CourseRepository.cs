using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;

namespace CleanArchitecture.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _dbContext;

        public CourseRepository(UniversityDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Course> GetCourses() 
        {
            return _dbContext.Courses;
        }
         
        
    }
}
