using PlatformOfCourses.Data.Interfaces;
using PlatformOfCourses.Data.Models;
using System.Collections.Generic;

namespace PlatformOfCourses.Data.Mocks
{
    public class MockCategory : ICourseCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryName = "Math",Description = "Courses about math"},
                    new Category{ CategoryName = "Programming",Description = "Courses about programming"},
                };
            }
        }
    }
}
