using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Application.Contracts.Interfaces;
using Todo.Domain.Entities;
using Todo.Infrastructure.Persistence;

namespace Todo.Infrastructure.Repositories
{
   public class TodoRepository : RepositoryBase<TodoItem>, ITodoRepository
    {
        public TodoRepository(TodoContext dbContext) : base(dbContext)
        {
        }
    }
}
