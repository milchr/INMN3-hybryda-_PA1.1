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

        public async Task<List<TodoItem>> GetItems()
        {
            return await restApiClient.GetTodoItems();
        }
    }
}
