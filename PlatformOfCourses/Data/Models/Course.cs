namespace PlatformOfCourses.Data.Models
{
    public class Course
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Language { set; get; }

        public string ShortDesc { set; get; }

        public string LongDesc { set; get; }

        public string Img { set; get; }

        public decimal Price { set; get; }

        public bool IsFavourite { set; get; }

        public int CategoryId { set; get; }

        public virtual Category Category { set; get; }
    }
}
