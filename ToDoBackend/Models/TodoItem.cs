﻿using System.ComponentModel.DataAnnotations;

namespace ToDoBackend.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean isDone { get; set; }

        public TodoItem(int id, string title, string description, bool isDone)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.isDone = isDone;
        }
    }
}
