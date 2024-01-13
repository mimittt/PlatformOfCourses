namespace PlatformOfCourses.Data.Models
{
    public class User
    {
        public int ID { set; get; }

        public string NicNname { set; get; }

        public string Password { set; get; }

        public string Email { set; get; }

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public int Roleid { set; get; }

        public virtual Role Role { set; get; }

        
    }
}
