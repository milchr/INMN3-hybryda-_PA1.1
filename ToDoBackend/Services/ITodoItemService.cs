using ToDoBackend.Dtos;

namespace ToDoBackend.Services
{
    public interface ITodoItemService
    {
        Task<TodoItemDto> GetTodoItem(int id);
        Task<List<TodoItemDto>> GetAllTodoItems();
        Task<TodoItemDto> CreateTodoItem(TodoItemDto todoItemDto);
        Task<TodoItemDto> UpdateTodoItem(TodoItemDto todoItemDto);
        Task DeleteTodoItem(int id);
    }
}
