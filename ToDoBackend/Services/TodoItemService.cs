using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ToDoBackend.data;
using ToDoBackend.Dtos;

namespace ToDoBackend.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ToDoContext db;
        private readonly IMapper mapper;

        public TodoItemService(ToDoContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public Task<TodoItemDto> createTodoItem(TodoItemDto todoItemDto)
        {
            throw new NotImplementedException();
        }

        public void deleteTodoItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TodoItemDto>> getAllTodoItems()
        {
            var items = await db.TodoItems.ToListAsync();
            return mapper.Map<List<TodoItemDto>>(items);
        }

        public async Task<TodoItemDto> GetTodoItem(int id)
        {
            var task = await db.TodoItems.FindAsync(id);
            return mapper.Map<TodoItemDto>(task);
        }

        public Task<TodoItemDto> updateTodoItem(TodoItemDto todoItemDto)
        {
            throw new NotImplementedException();
        }
    }
}
