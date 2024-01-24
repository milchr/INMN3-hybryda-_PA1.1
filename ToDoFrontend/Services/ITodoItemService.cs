using ToDoFrontend.Models;

namespace ToDoFrontend.Services
{
    public interface ITodoItemService
    {
        Task<List<TodoItem>> GetItems();

        Task<TodoItem> CreateTodoItem(TodoItem todoItem);

        Task<TodoItem> EditTodoItem(TodoItem todoItem);

        void DeleteTodoItem(int id);
    }
}
