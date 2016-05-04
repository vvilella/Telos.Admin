using System;
using Telos.Admin.Business.Base;
using Telos.Admin.Data.Repositories;
using Telos.Admin.Infrastructure;
using Telos.Admin.Model;

namespace Telos.Admin.Business
{
    public class UnidadeService : BaseEntityService<Unidade>
    {
        private UnidadeRepository repository { get { return (UnidadeRepository)entityRepository; } }

        public UnidadeService(UnidadeRepository repository, IDatabaseControlContext context)
            : base(context)
        {
            this.entityRepository = repository;
        }

        public virtual Unidade FindByCode(string code)
        {
            return repository.FindByCode(code);
        }

        public override void Create(Unidade entity)
        {
            setModifiedDate(entity);
            base.Create(entity);
        }

        public override void Update(Unidade entity)
        {
            setModifiedDate(entity);
            base.Update(entity);
        }

        private void setModifiedDate(Unidade entity)
        {
            entity.ModifiedDate = DateTime.Now;
        }

        public virtual void Delete(string code)
        {
            Unidade entity = repository.FindByCode(code);
            entityRepository.Delete(entity);
            context.SaveChanges();
        }
    }
}
