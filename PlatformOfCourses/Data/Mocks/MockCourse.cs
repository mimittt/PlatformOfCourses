using PlatformOfCourses.Data.Interfaces;
using PlatformOfCourses.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlatformOfCourses.Data.Mocks
{
    public class MockCourse : IAllCourse
    {
        private readonly ICourseCategory _courseCategory = new MockCategory();


        public IEnumerable<Course> Courses
        {
            get
            {
                return new List<Course>
                {
                    new Course { Name = "C# Basic", ShortDesc = "", LongDesc = "", Img = "", Price = 100, IsFavourite = true,  Category = _courseCategory.AllCategories.Last() },
                    new Course { Name = "Algebra", ShortDesc = "", LongDesc = "", Img = "", Price = 100, IsFavourite = false,  Category = _courseCategory.AllCategories.First() }

                };
            }
        }
        public IEnumerable<Course> GetFavCourse { get; set; }

        public Course GetObjectCheese(int courseId)
        {
            throw new System.NotImplementedException();
        }
    }
}
