using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Application.Features.Todo.Commands.CreateTodoItem;
using Todo.Application.Features.Todo.Queries.GetTodoItems;

namespace Todo.Application.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Todo.Domain.Entities.TodoItem, CreateTodoItemCommand>().ReverseMap();
            CreateMap<Todo.Domain.Entities.TodoItem, TodoItemDto>().ReverseMap();

        }
    }
}
