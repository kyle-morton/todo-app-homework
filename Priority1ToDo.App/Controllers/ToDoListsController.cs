using Microsoft.AspNetCore.Mvc;

namespace Priority1ToDo.App.Controllers
{
    public class ToDoListsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
