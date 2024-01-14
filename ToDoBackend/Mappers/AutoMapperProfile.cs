using AutoMapper;
using ToDoBackend.Dtos;
using ToDoBackend.Models;

namespace ToDoBackend.mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<TodoItemDto, TodoItem>();
            CreateMap<TodoItem, TodoItemDto>();
        }
    }
}
