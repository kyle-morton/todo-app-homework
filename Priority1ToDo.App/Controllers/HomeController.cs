using Microsoft.AspNetCore.Mvc;
using Priority1ToDo.App.Models;
using Priority1ToDo.Core.Services.Interfaces;
using System.Diagnostics;

namespace Priority1ToDo.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToDoListService _toDoListService;

        public HomeController(ILogger<HomeController> logger, IToDoListService toDoListService)
        {
            _logger = logger;
            _toDoListService = toDoListService;
        }

        public async Task<IActionResult> Index()
        {
            var todoLists = await _toDoListService.GetAllAsync();


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