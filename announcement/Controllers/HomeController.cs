using Microsoft.AspNetCore.Mvc;
using Homework1.Models;
using System.Linq;

namespace Homework1.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            ViewBag.AnnouncementCount = Repository.Announcements.Count;
            ViewBag.CurrentDateTime = DateTime.Now;
            ViewBag.WelcomeMessage = "Welcome to the Announcement Page!";
            
            return View(Repository.Announcements);
        }

        [HttpGet]
        public IActionResult AddAnnouncement() {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Anno announcement) {
            // Yeni duyuruyu ekle
            Repository.AddAnnouncement(announcement);
            
            // Yeni duyurunun detay sayfasına yönlendirme
            return RedirectToAction("Details", new { id = announcement.Id });
        }

        public IActionResult Details(int id) {
            // ID ile duyuruyu bul
            var announcement = Repository.Announcements.FirstOrDefault(a => a.Id == id);
            if (announcement == null) {
                return NotFound();
            }
            return View(announcement);
        }
    }
}
