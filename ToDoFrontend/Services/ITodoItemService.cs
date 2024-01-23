using ToDoFrontend.Models;

namespace ToDoFrontend.Services
{
    public interface ITodoItemService
    {
        Task<List<TodoItem>> GetItems();
    }
}
