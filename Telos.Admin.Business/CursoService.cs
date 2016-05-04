using System;
using Telos.Admin.Business.Base;
using Telos.Admin.Data.Repositories;
using Telos.Admin.Infrastructure;
using Telos.Admin.Model;

namespace Telos.Admin.Business
{
    public class CursoService : BaseEntityService<Curso>
    {
        private CursoRepository repository { get { return (CursoRepository)entityRepository; } }

        public CursoService(CursoRepository repository, IDatabaseControlContext context)
            : base(context)
        {
            this.entityRepository = repository;
        }

        public virtual Curso FindByCode(string code)
        {
            return repository.FindByCode(code);
        }

        public override void Create(Curso entity)
        {
            setModifiedDate(entity);
            base.Create(entity);
        }

        public override void Update(Curso entity)
        {
            setModifiedDate(entity);
            base.Update(entity);
        }

        private void setModifiedDate(Curso entity)
        {
            entity.ModifiedDate = DateTime.Now;
        }

        public virtual void Delete(string code)
        {
            Curso entity = repository.FindByCode(code);
            entityRepository.Delete(entity);
            context.SaveChanges();
        }
    }
}
