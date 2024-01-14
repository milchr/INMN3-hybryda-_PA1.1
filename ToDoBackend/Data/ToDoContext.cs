using Microsoft.EntityFrameworkCore;
using ToDoBackend.Models;

namespace ToDoBackend.data
{
    public class ToDoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public ToDoContext(DbContextOptions options) : base(options)
        {
        }
    }
}
