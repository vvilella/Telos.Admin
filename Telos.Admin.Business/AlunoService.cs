using System;
using Telos.Admin.Business.Base;
using Telos.Admin.Data.Repositories;
using Telos.Admin.Infrastructure;
using Telos.Admin.Model;

namespace Telos.Admin.Business
{
    public class AlunoService : BaseEntityService<Aluno>
    {
        private AlunoRepository repository { get { return (AlunoRepository)entityRepository; } }

        public AlunoService(AlunoRepository repository, IDatabaseControlContext context)
            : base(context)
        {
            this.entityRepository = repository;
        }

        public virtual Aluno FindByCode(long code)
        {
            return repository.FindByCode(code);
        }

        public override void Create(Aluno entity)
        {
            setModifiedDate(entity);
            base.Create(entity);
        }

        public override void Update(Aluno entity)
        {
            setModifiedDate(entity);
            base.Update(entity);
        }

        private void setModifiedDate(Aluno entity)
        {
            entity.ModifiedDate = DateTime.Now;
        }

        public virtual void Delete(long code)
        {
            Aluno entity = repository.FindByCode(code);
            entityRepository.Delete(entity);
            context.SaveChanges();
        }
    }
}
