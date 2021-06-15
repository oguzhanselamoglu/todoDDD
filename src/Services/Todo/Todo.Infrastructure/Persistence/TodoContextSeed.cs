using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Infrastructure.Persistence
{
    public class TodoContextSeed
    {
        public static async Task SeedAsync(TodoContext todoContext, ILogger<TodoContextSeed> logger)
        {
            //if (!todoContext.TodoItems.Any())
            //{
            //    todoContext.TodoItems.AddRange(GetPreconfiguredTodo());
            //    await todoContext.SaveChangesAsync();
            //    logger.LogInformation("Seed database associated with context {DbContextName}", typeof(TodoContext).Name);
            //}
        }

        //private static IEnumerable<TodoItem> GetPreconfiguredTodos()
        //{
          
        //}
    }
}
