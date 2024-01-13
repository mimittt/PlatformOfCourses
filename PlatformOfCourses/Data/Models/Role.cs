using System.Collections.Generic;

namespace PlatformOfCourses.Data.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<User> Users { set; get; }
    }
}
