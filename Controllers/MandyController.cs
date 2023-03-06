using Microsoft.AspNetCore.Mvc;

namespace GraduateProject.Controllers
{
    public class MandyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
