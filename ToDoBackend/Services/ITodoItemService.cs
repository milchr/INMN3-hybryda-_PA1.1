using ToDoBackend.Dtos;

namespace ToDoBackend.Services
{
    public interface ITodoItemService
    {
        Task<TodoItemDto> GetTodoItem(int id);
        Task<List<TodoItemDto>> getAllTodoItems();
        Task<TodoItemDto> createTodoItem(TodoItemDto todoItemDto);
        Task<TodoItemDto> updateTodoItem(TodoItemDto todoItemDto);
        void deleteTodoItem(int id);
    }
}
