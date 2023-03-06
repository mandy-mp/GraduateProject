using GraduateProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraduateProject.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View(new ProfileViewModel { Name = "Example", 
                                               Surname = "One", 
                                               DOB =  "2000/02/20", 
                                               Age = 23, 
                                               Country = "South Africa", 
                                               City = "Pretoria" });
        }
    }
}
