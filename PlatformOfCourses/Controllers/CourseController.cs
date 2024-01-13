

using Microsoft.AspNetCore.Mvc;
using PlatformOfCourses.Data.Interfaces;
using PlatformOfCourses.ViewModels;

namespace PlatformOfCourses.Controllers
{
    public class CourseController: Controller
    {
        private readonly IAllCourse _allcourse;
        private readonly ICourseCategory _allcategories;

        public CourseController(IAllCourse allcourse, ICourseCategory allcategories)
        {
            _allcourse = allcourse;
            _allcategories = allcategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с курсами";
            CourseListViewModel obj = new CourseListViewModel();
            obj.AllCourse = _allcourse.Courses;
            obj.CoursCategory = "Courses";
            return View(obj);
        }
    }
}
