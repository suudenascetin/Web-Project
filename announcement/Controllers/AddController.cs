using Homework1.Models;
using Microsoft.AspNetCore.Mvc;


namespace Announcement.Controllers

{
    public class  AddController : Controller{

        public IActionResult Index (){

            return View();
        }
        public IActionResult AddAnnouncement (){

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAnnouncement ([FromForm]Anno model)
        {
            model.AddAnn = DateTime.Now; 
    Repository.AddAnnouncement(model);

    // Success mesajını TempData'ya ekleyin
    TempData["SuccessMessage"] = "Announcement added successfully!";

    return Redirect("/");
        }



    }
}