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

        [Route("MengikutiPelatihan/{id}/{id2}/{nama}")]
        public IActionResult Section(int id, int id2, string nama)
        {
            ViewBag.idPelatihan = id;
            ViewBag.idSection = id2;
            ViewBag.namaPelatihan = nama;
            return View();
        }

        [Route("SebelumMengikutiPelatihan/{id}/{id2}/{nama}")]
        public IActionResult Welcome(int id, int id2, string nama)
        {
            ViewBag.idPelatihan = id;
            ViewBag.idSection = id2;
            ViewBag.namaPelatihan = nama;
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [Route("MengerjakanExercise/{id}/{id2}/{nama}")]
        public IActionResult Exercise(int id, int id2, string nama)
        {
            ViewBag.idPelatihan = id;
            ViewBag.idSection = id2;
            ViewBag.namaPelatihan = nama;
            return View();
        }
        public IActionResult Kelas()
        {
            return View();
        }
    }
}
