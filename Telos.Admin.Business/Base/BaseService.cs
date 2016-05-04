using System.Collections.Generic;
using System.Linq;
using Telos.Admin.Data.Base;
using Telos.Admin.Infrastructure;

namespace Telos.Admin.Business.Base
{
    [Log]
    public abstract class BaseEntityService<TEntity> where TEntity : class
    {
        protected BaseRepository<TEntity> entityRepository;
        protected IDatabaseControlContext context;

        public BaseEntityService(IDatabaseControlContext context)
        {
            this.context = context;
        }

        public virtual TEntity FindById(int Id)
        {
            return entityRepository.FindById(Id);
        }

        public virtual IList<TEntity> RetrieveAll()
        {
            return entityRepository.RetrieveAll().ToList();
        }

        public virtual void Create(TEntity entity)
        {
            entityRepository.Create(entity);
            context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            entityRepository.Update(entity);
            context.SaveChanges();
        }

        public virtual void Delete(int Id)
        {
            TEntity entity = entityRepository.FindById(Id);
            entityRepository.Delete(entity);
            context.SaveChanges();
        }
    }
}
