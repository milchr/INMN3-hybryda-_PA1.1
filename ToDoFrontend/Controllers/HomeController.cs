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

        public async Task<IActionResult> CreateTodoItem(TodoItem todoItem)
        {
            return View();
        }

        public async Task<IActionResult> EditTodoItem(TodoItem todoItem)
        {
            return View();
        }

        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            todoItemService.DeleteTodoItem(id);
            return RedirectToAction("TodoItems");
        }

        public async Task<IActionResult> Create(TodoItem todoItem)
        {
            await todoItemService.CreateTodoItem(todoItem);
            return RedirectToAction("TodoItems");
        }

        public async Task<IActionResult> Edit(TodoItem todoItem)
        {
            await todoItemService.EditTodoItem(todoItem);
            return RedirectToAction("TodoItems");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}