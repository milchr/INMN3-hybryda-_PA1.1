using Newtonsoft.Json;
using ToDoFrontend.Models;

namespace ToDoFrontend.Clients
{
    public class RestApiClient
    {
        private readonly HttpClient client = new HttpClient();
        private static readonly string URL = "https://localhost:7006/api/TodoItem";

        public async Task<List<TodoItem>> GetTodoItems() {
            List<TodoItem> items = new List<TodoItem>();
            await Task.Run(() =>
            {
                var response = client.GetAsync(URL).Result;
                if (response.IsSuccessStatusCode)
                {
                    items.AddRange(JsonConvert.DeserializeObject<List<TodoItem>>(response.Content.ReadAsStringAsync().Result));
                }
                else {
                    Console.WriteLine("error");
                }
            });

            return items;
        }

        public async Task<TodoItem> CreateTodoItem(TodoItem todoItem)
        {
            TodoItem newTodoItem = null;
            await Task.Run(() =>
            {
                var response = client.PostAsJsonAsync(URL, todoItem).Result;
                if (response.IsSuccessStatusCode)
                {
                    newTodoItem = JsonConvert.DeserializeObject<TodoItem>(response.Content.ReadAsStringAsync().Result);
                } else {
                    Console.WriteLine("error");
                }
            });

            return newTodoItem;
        }

        public async Task<TodoItem> EditTodoItem(TodoItem todoItem)
        {
            await Task.Run(() =>
            {
                var response = client.PatchAsJsonAsync(URL, todoItem).Result;
                if (response.IsSuccessStatusCode)
                {
                    todoItem = JsonConvert.DeserializeObject<TodoItem>(response.Content.ReadAsStringAsync().Result);
                } else {
                    Console.WriteLine("error");
                }
            });

            return todoItem;
        }

        public async void DeleteTodoItem(int id)
        {
            await Task.Run(() =>
            {
                var response = client.DeleteAsync(URL + "/" + id).Result;
            });
        }
    }
}
