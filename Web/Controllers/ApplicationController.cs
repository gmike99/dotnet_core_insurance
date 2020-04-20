using Microsoft.AspNetCore.Mvc;
using Web.Models;


namespace Web.Controllers
{
    public class ApplicationController : Controller
    {
        // GET
        public IActionResult Application()
        {
            return View(new ApplicationViewModel());
        }
    }
}