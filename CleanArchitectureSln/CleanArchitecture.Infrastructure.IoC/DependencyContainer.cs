using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Repository;

namespace CleanArchitecture.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application layer
            services.AddScoped<ICourseService, CourseService>();

            //Infrastructure.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();

        }

       
    }
}
