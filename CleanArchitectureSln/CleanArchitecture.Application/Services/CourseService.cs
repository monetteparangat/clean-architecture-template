using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;


namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public CourseVM GetCourses()
        {

            return new CourseVM()
            {
                Courses = _courseRepository.GetCourses()
            };

        }

        public void Create(CourseVM courseVM)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseVM.Name,
                courseVM.Description,
                courseVM.ImageUrl
                );

            _bus.SendCommand(createCourseCommand);
        }

    }
}
