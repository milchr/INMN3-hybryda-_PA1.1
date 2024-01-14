using System.ComponentModel.DataAnnotations;

namespace ToDoBackend.Dtos
{
    public class TodoItemDto
    {
        public int? Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public bool? isDone { get; set; }

        public TodoItemDto(int? id, string title, string description, bool? isDone)
        {
            Id = id;
            Title = title;
            Description = description;
            this.isDone = isDone;
        }
    }
}
