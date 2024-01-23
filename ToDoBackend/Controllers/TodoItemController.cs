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
        public async Task<ActionResult<List<TodoItemDto>>> getTodoItems()
        {
            await Console.Out.WriteLineAsync("GetAllTodoItems");
            return Ok(await todoItemService.GetAllTodoItems());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<TodoItemDto>>> getTodoItem([FromRoute] int id)
        {
            return Ok(await todoItemService.GetTodoItem(id));
        }

        [HttpPost]
        public async Task<ActionResult<TodoItemDto>> createTodoItem([FromBody] TodoItemDto todoItemDto)
        {
            return Ok(await todoItemService.CreateTodoItem(todoItemDto));
        }

        [HttpPatch]
        public async Task<ActionResult<TodoItemDto>> updateTodoItem([FromBody] TodoItemDto todoItemDto)
        {
            return Ok(await todoItemService.UpdateTodoItem(todoItemDto));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> deleteTodoItem([FromRoute] int id)
        {
            await todoItemService.DeleteTodoItem(id);
            return Ok();
        }
    }
}
