using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Interview.DataAccess.Core
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expressionFilter = null)
        {
            using (TContext context = new TContext())
            {
                return expressionFilter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(expressionFilter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expressionFilter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(expressionFilter);
            }
        }

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
