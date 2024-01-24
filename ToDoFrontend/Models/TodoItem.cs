using System.ComponentModel.DataAnnotations;

namespace ToDoFrontend.Models
{
    public class TodoItem
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean? isDone { get; set; }

        public TodoItem(int? id, string title, string description, bool? isDone)
        {
            Id = id;
            Title = title;
            Description = description;
            this.isDone = isDone;
        }

        public TodoItem()
        {
        }
    }
}
