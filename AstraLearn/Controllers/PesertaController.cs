using Microsoft.AspNetCore.Mvc;

namespace AstraLearn.Controllers
{
    public class PesertaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sertifikat()
        {
            return View();
        }

        public IActionResult LihatKelas()
        {
            return View();
        }

        public IActionResult KelasPelatihan()
        {
            return View();
        }

        public IActionResult Exam()
        {
            return View();
        }

        [Route("MengikutiPelatihan/{id}/{id2}")]
        public IActionResult Section(int id, int id2)
        {
            ViewBag.idPelatihan = id;
            ViewBag.idSection = id2;
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Exercise()
        {
            return View();
        }
        public IActionResult Kelas()
        {
            return View();
        }
    }
}
