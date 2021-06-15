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
using Todo.Domain.Entities;

namespace Todo.Application.Features.Todo.Commands.CreateTodoItem
{
    public class CreateTodoItemCommand: IRequest<int>
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime TaskDate { get; set; }
    }

    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, int>
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateTodoItemCommandHandler> _logger;

        public CreateTodoItemCommandHandler(ITodoRepository todoRepository, IMapper mapper, ILogger<CreateTodoItemCommandHandler> logger)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TodoItem>(request);
            var newTodo = await _todoRepository.AddAsync(entity);

            _logger.LogInformation($"Order {newTodo.Id} is successfully created.");


            return newTodo.Id;
        }
    }
}
