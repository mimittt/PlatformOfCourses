using System.Collections.Generic;

namespace PlatformOfCourses.Data.Models
{
    public class Category
    {
        public int ID { set; get; }

        public string CategoryName { set; get; }

        public string Description { set; get; }

        public List<Course> Courses { set; get; }
    }
}
