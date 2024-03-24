using Microsoft.AspNetCore.Mvc;
using Portfolio.Contracts;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContact contactService;
        public HomeController(IContact _contact)
        {
            contactService = _contact;
        }
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactUs(Contact contact)
        {
            contactService.AddContact(contact);
            return RedirectToAction("ThankU");
        }
        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult ThankU()
        {
            return View();
        }
    }
}
