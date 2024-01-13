namespace PlatformOfCourses.Data.Models
{
    public class Review
    {
        public int ID { set; get; }

        public string Comment { set; get; }

        public string Stars { set; get; }

        public int Userid { set; get; }

        public int Courseid { set; get; }

        public virtual Course Course { set; get; }

        public virtual User User{ set; get; }

    }
}
