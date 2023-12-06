using Microsoft.AspNetCore.Mvc;

namespace AstraLearn.Controllers
{
    public class DataPelatihanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }

        [Route("Section/{nama}/{id}")]
        public IActionResult Section(string nama, int id)
        {
            ViewBag.idSection = id;
            ViewBag.namaPelatihan = nama;
            return View();
        }
        [Route("Exercise/{nama}/{id}")]
        public IActionResult Exercise(string nama, int id)
        {
            ViewBag.idSection = id;
            ViewBag.namaSection = nama;
            return View();
        }
        [Route("Exam/{nama}/{id}")]
        public IActionResult Exam(string nama, int id)
        {
            ViewBag.idPelatihan = id;
            ViewBag.namaPelatihan = nama;
            return View();
        }
    }
}
