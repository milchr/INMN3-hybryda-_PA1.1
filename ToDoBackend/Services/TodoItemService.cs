using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ToDoBackend.data;
using ToDoBackend.Dtos;
using ToDoBackend.Exceptions;
using ToDoBackend.Models;

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

        public async Task<TodoItemDto> CreateTodoItem(TodoItemDto todoItemDto)
        {
            var item = mapper.Map<TodoItem>(todoItemDto);
            await db.TodoItems.AddAsync(item);
            await db.SaveChangesAsync();

            return mapper.Map<TodoItemDto>(item);
        }

        public async Task DeleteTodoItem(int id)
        {
            var item = await db.TodoItems.FindAsync(id);
            if (item == null)
            {
                throw new NotFoundException("TodoItem not found");
            }

            db.TodoItems.Remove(item);
            await db.SaveChangesAsync();
        }

        public async Task<List<TodoItemDto>> GetAllTodoItems()
        {
            var items = await db.TodoItems.ToListAsync();

            return mapper.Map<List<TodoItemDto>>(items);
        }

        public async Task<TodoItemDto> GetTodoItem(int id)
        {
            var item = await db.TodoItems.FindAsync(id);

            return mapper.Map<TodoItemDto>(item);
        }

        public async Task<TodoItemDto> UpdateTodoItem(TodoItemDto todoItemDto)
        {
            var item = mapper.Map<TodoItem>(todoItemDto);
            db.TodoItems.Update(item);
            await db.SaveChangesAsync();

            return mapper.Map<TodoItemDto>(item);
        }
    }
}
