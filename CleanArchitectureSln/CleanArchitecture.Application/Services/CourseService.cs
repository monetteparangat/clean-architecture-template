﻿using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;


namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository) 
        {
            _courseRepository = courseRepository;
        }

        public CourseVM GetCourses() {
            
            return new CourseVM()
            {
                Courses = _courseRepository.GetCourses()
            };

        }

    }
}
