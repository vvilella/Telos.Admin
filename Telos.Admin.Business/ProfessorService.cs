using System;
using Telos.Admin.Business.Base;
using Telos.Admin.Data.Repositories;
using Telos.Admin.Infrastructure;
using Telos.Admin.Model;

namespace Telos.Admin.Business
{
    public class ProfessorService : BaseEntityService<Professor>
    {
        private ProfessorRepository repository { get { return (ProfessorRepository)entityRepository; } }

        public ProfessorService(ProfessorRepository repository, IDatabaseControlContext context)
            : base(context)
        {
            this.entityRepository = repository;
        }

        public virtual Professor FindByCode(long code)
        {
            return repository.FindByCode(code);
        }

        public override void Create(Professor entity)
        {
            setModifiedDate(entity);
            base.Create(entity);
        }

        public override void Update(Professor entity)
        {
            setModifiedDate(entity);
            base.Update(entity);
        }

        private void setModifiedDate(Professor entity)
        {
            entity.ModifiedDate = DateTime.Now;
        }

        public virtual void Delete(long code)
        {
            Professor entity = repository.FindByCode(code);
            entityRepository.Delete(entity);
            context.SaveChanges();
        }
    }
}
