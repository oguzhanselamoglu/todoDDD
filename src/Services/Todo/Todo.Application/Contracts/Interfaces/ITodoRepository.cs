using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Application.Contracts.Interfaces
{
    public interface ITodoRepository: IAsyncRepository<Todo.Domain.Entities.TodoItem>
    {

    }
}
