using Microsoft.AspNetCore.Mvc;

namespace MySchoolWebApplication.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactInfo()
        {
            return View();
        }
    }
}
