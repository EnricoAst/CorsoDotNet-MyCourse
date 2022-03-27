using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services.Application;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index() 
        {
            var courseService = new  CourseService();
            return View();
        }

        public IActionResult Detail(string id) 
        {
            return View();
        }
    }
}