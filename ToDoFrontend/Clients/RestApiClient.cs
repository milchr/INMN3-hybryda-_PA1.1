using Newtonsoft.Json;
using ToDoFrontend.Models;

namespace ToDoFrontend.Clients
{
    public class RestApiClient
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<List<TodoItem>> GetTodoItems() {
            List<TodoItem> items = new List<TodoItem>();
            await Task.Run(() =>
            {
                var response = client.GetAsync("https://localhost:7006/api/TodoItem").Result;
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
    }
}
