using System.Linq.Expressions;

namespace Interview.DataAccess.Core
{
   
        public interface IEntityRepository<T> where T : class,  new()
        {
            List<T> GetAll(Expression<Func<T, bool>> expressionFilter = null);

            T Get(Expression<Func<T, bool>> expressionFilter);

            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
        }
    
}
