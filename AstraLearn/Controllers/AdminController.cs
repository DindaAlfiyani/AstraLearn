using Microsoft.AspNetCore.Mvc;

namespace AstraLearn.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataPelatihan()
        {
            return View();
        }
    }
}
