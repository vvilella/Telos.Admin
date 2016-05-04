using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telos.Admin.Business.Base;
using Telos.Admin.Data.Repositories;
using Telos.Admin.Infrastructure;
using Telos.Admin.Model;

namespace Telos.Admin.Business
{
    public class MatriculaService : BaseEntityService<Matricula>
    {
        private MatriculaRepository repository { get { return (MatriculaRepository)entityRepository; } }

        public MatriculaService(MatriculaRepository repository, IDatabaseControlContext context)
            : base(context)
        {
            this.entityRepository = repository;
        }

        public virtual Matricula FindByCode(string code)
        {
            return repository.FindByCode(code);
        }

        public override void Create(Matricula entity)
        {
            setModifiedDate(entity);
            base.Create(entity);
        }

        public override void Update(Matricula entity)
        {
            setModifiedDate(entity);
            base.Update(entity);
        }

        private void setModifiedDate(Matricula entity)
        {
            // entity.ModifiedDate = DateTime.Now;
        }

        public virtual void Delete(string code)
        {
            Matricula entity = repository.FindByCode(code);
            entityRepository.Delete(entity);
            context.SaveChanges();
        }
    }
}

