using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Todo.Application.Features.Todo.Commands.CreateTodoItem;
using Todo.Application.Features.Todo.Queries.GetTodoItems;

namespace Todo.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TodoController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost(Name = "CreateTodoItem")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTodoItem([FromBody] CreateTodoItemCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost(Name = "GetTodoItems")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetTodoItems([FromBody] GetTodoItemsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

    }
}
