using PlatformOfCourses.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace PlatformOfCourses.ViewModels
{
    public class CourseListViewModel
    {
        public IEnumerable<Course> AllCourse {  get; set; }

        public string CoursCategory {  get; set; }

    }
}
