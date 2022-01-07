using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjetoElevadorDocumentacao.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult Documentacao()
        {
            return View();
        }

        public IActionResult Trabalho()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    ViewData["Message"] = "error"
        //}

    }
}

