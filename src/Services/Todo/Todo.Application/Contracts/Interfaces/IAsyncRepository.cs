using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Common;

namespace Todo.Application.Contracts.Interfaces
{
	public interface IAsyncRepository<T> where T : EntityBase
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate);
		Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
										Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
										string includeString = null,
										bool disableTracking = true);
		Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
									   Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
									   List<Expression<Func<T, object>>> includes = null,
									   bool disableTracking = true);
		Task<T> GetByIdAsync(int id);
		Task<T> AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
	}
}
