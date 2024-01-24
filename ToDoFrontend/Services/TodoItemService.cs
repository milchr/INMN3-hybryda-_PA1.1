using ToDoFrontend.Models;
using ToDoFrontend.Clients;

namespace ToDoFrontend.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly RestApiClient restApiClient;

        public TodoItemService(RestApiClient restApiClient)
        {
            this.restApiClient = restApiClient;
        }

        public async Task<TodoItem> CreateTodoItem(TodoItem todoItem)
        {
            return await restApiClient.CreateTodoItem(todoItem);
        }

        public async void DeleteTodoItem(int id)
        {
            restApiClient.DeleteTodoItem(id);
        }

        public async Task<TodoItem> EditTodoItem(TodoItem todoItem)
        {
            return await restApiClient.EditTodoItem(todoItem);
        }

        public async Task<List<TodoItem>> GetItems()
        {
            return await restApiClient.GetTodoItems();
        }
    }
}
