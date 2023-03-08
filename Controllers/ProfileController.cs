using GraduateProject.Data;
using GraduateProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraduateProject.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProfileController (ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {

            return View(context.Profile.ToList());
        }

        //GET: Home/Profile/Create
        public IActionResult Create() 
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public IActionResult Create(Profile profile)
        {
            try
            {
                context.Add(profile);
                context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        //GET: Home/Profile/Edit/{id}
        public IActionResult Edit(int Id)
        {
            var profile = context.Profile.Find(Id);
            if (profile != null)
            {
                return View(profile);
            }
            else
            {
                return RedirectToAction("Index");
            }      
        }

        [HttpPost]
        public ActionResult Edit(Profile profile)
        {
            if (profile != null)
            {
                try
                {
                    context.Update(profile);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View() ;
                } 
            }
            else
            {
                return View() ;
            }
        }

        public IActionResult Delete(int Id)
        {
            var profile = context.Profile.Find(Id);
            if (profile != null)
            {
                try
                {
                    context.Profile.Remove(profile);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            { 
                return View(); 
            }  
        }
    }
}
