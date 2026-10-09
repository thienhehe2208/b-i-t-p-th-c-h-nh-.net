using Microsoft.AspNetCore.Mvc;
using QuanLyKyThi_UNETI1_TI17A5HN.Models;
using System.Diagnostics;

namespace QuanLyKyThi_UNETI1_TI17A5HN.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
