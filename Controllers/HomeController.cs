using Configuation.Services;
using FirstAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private TotalUsers totalUsers;

        public HomeController(TotalUsers tu)
        {
            totalUsers = tu;
        }

        public string Index()
        {
            return "Total Users are: " + totalUsers.TUsers();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}