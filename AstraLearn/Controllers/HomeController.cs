﻿using AstraLearn.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AstraLearn.Models;
using System.Diagnostics;

namespace AstraLearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository _userRepository;

		public HomeController(IConfiguration configuration)
		{
			_userRepository = new UserRepository(configuration);
		}

        public IActionResult Login(string username, string password)
        {
            User user = _userRepository.getDataByUsername_Password(username, password);

            //mengkonversi model menjadi data json
            string serializedModel = JsonConvert.SerializeObject(user); //jso seperti string tetapi ada kurung kurawalnya

            if (user.Username == username && user.Password == password && user.HakAkses == "Peserta")
            {
                //membuat sesi berdasarkan key-value berikut
                HttpContext.Session.SetString("Identity", serializedModel);
                HttpContext.Session.SetString("Peran", user.HakAkses);
                // Contoh penggunaan session untuk menyimpan informasi bahwa pengguna telah login
                HttpContext.Session.SetString("IsLoggedIn", "true");
                return RedirectToAction("Index", "Peserta");
            }
            if (user.Username == username && user.Password == password && user.HakAkses == "Admin")
            {
                //membuat sesi berdasarkan key-value berikut
                HttpContext.Session.SetString("Identity", serializedModel);
                HttpContext.Session.SetString("Peran", user.HakAkses);
                // Contoh penggunaan session untuk menyimpan informasi bahwa pengguna telah login
                HttpContext.Session.SetString("IsLoggedIn", "true");
                return RedirectToAction("Index", "Admin");
            }
            if (user.Username == username && user.Password == password && user.HakAkses == "Pelatih")
            {
                //membuat sesi berdasarkan key-value berikut
                HttpContext.Session.SetString("Identity", serializedModel);
                HttpContext.Session.SetString("Peran", user.HakAkses);
                // Contoh penggunaan session untuk menyimpan informasi bahwa pengguna telah login
                HttpContext.Session.SetString("IsLoggedIn", "true");
                return RedirectToAction("Index", "Pelatih");
            }
            else
            {
                TempData["ErrorLogin"] = "Username / Password Salah!";
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult CaraBelajar()
        {
            // Check if user is authenticated
            bool isLoggedIn = User.Identity.IsAuthenticated;

            // Pass the login status to the view
            ViewBag.IsLoggedIn = isLoggedIn;

            return View();
        }

        public IActionResult Index()
        {
            Response.Cookies.Delete(".AspNetCore.Session");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult CaraDapatSertifikat()
        {
            // Check if user is authenticated
            bool isLoggedIn = User.Identity.IsAuthenticated;

            // Pass the login status to the view
            ViewBag.IsLoggedIn = isLoggedIn;

            return View();
        }

        public IActionResult Kelas()
        {
            // Check if user is authenticated
            bool isLoggedIn = User.Identity.IsAuthenticated;

            // Pass the login status to the view
            ViewBag.IsLoggedIn = isLoggedIn;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}