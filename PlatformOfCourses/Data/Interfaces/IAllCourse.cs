using PlatformOfCourses.Data.Models;
using System.Collections.Generic;

namespace PlatformOfCourses.Data.Interfaces
{
    public interface IAllCourse
    {
        IEnumerable<Course> Courses { get; }
        IEnumerable<Course> GetFavCourse { get; set; }
        Course GetObjectCheese(int cheeseId);
    }
}
