using PlatformOfCourses.Data.Models;
using System.Collections.Generic;

namespace PlatformOfCourses.Data.Interfaces
{
    public interface ICourseCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
