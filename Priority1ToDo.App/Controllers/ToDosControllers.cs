using Microsoft.AspNetCore.Mvc;

namespace Priority1ToDo.App.Controllers
{
    public class ToDosControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
