using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoFrontend.Models;
using ToDoFrontend.Services;

namespace ToDoFrontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITodoItemService todoItemService;

        public HomeController(ILogger<HomeController> logger, ITodoItemService todoItemService)
        {
            _logger = logger;
            this.todoItemService = todoItemService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> TodoItems()
        {
            List<TodoItem> items = await todoItemService.GetItems();
            return View(items);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}