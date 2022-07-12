using System.Linq.Expressions;
using RecipeApp.Core.Domain;

namespace RecipeApp.Core.Application.Repository
{

    public interface IRepository<T> where T : IEntity
    {
        Task<T> CreateAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> filter);
        Task<T> GetAsync(Guid id);
        Task<T> GetAsync(Expression<Func<T,bool>> filter);
        Task<T> Remove(T entity);
        Task<T> Update(T entity);
        
    }

}