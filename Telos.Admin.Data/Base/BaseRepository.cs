using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Telos.Admin.Infrastructure;

namespace Telos.Admin.Data.Base
{
    [Log]
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        protected DbContext context;
        protected DbSet<TEntity> dbSet;

        public BaseRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> RetrieveAll()
        {
            return this.dbSet.AsQueryable();
        }

        public virtual TEntity FindById(int id)
        {
            return this.dbSet.Find(id);
        }

        public virtual TEntity Create(TEntity entidade)
        {
            this.dbSet.Add(entidade);
            return entidade;
        }

        public virtual TEntity Update(TEntity entidade)
        {
            this.context.Entry(entidade).State = System.Data.EntityState.Modified;
            return entidade;
        }

        public virtual void Delete(int id)
        {
            TEntity entidade = this.FindById(id);
            this.dbSet.Remove(entidade);
        }

        public virtual void Delete(TEntity entidade)
        {
            this.dbSet.Remove(entidade);
        }

        public virtual void Delete(IList<TEntity> entidades)
        {
            foreach (TEntity entidade in entidades)
            {
                this.dbSet.Remove(entidade);
            }
        }
    }
}
