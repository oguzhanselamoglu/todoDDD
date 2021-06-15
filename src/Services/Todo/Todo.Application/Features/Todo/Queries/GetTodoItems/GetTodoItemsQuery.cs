using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Todo.Application.Contracts.Interfaces;

namespace Todo.Application.Features.Todo.Queries.GetTodoItems
{
    public class TodoItemDto
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime TaskDate { get; set; }
    }
    public class GetTodoItemsQuery: IRequest<List<TodoItemDto>>
    {
        public int Id { get; set; }
        
    }

    public class GetTodoItemQueryHandler : IRequestHandler<GetTodoItemsQuery, List<TodoItemDto>>
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetTodoItemQueryHandler> logger;

        public GetTodoItemQueryHandler(ITodoRepository todoRepository, IMapper mapper, ILogger<GetTodoItemQueryHandler> logger)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
            this.logger = logger;
        }

        public async Task<List<TodoItemDto>> Handle(GetTodoItemsQuery request, CancellationToken cancellationToken)
        {
            var todoItems = await _todoRepository.GetAllAsync();
            var result = _mapper.Map<List<TodoItemDto>>(todoItems);

            return result;
        }
    }
}
