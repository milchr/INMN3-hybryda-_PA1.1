using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoBackend.Dtos;
using ToDoBackend.Services;

namespace ToDoBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoItemService todoItemService;

        public TodoItemController(ITodoItemService todoItemService)
        {
            this.todoItemService = todoItemService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TodoItemDto>>> getTasks()
        {
            return Ok(await todoItemService.getAllTodoItems());
        }

        [HttpGet("id")]
        public async Task<ActionResult<List<TodoItemDto>>> getTask([FromRoute] int id)
        {
            return Ok(await todoItemService.GetTodoItem(id));
        }
    }
}
