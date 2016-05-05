using Telos.Admin.Data.Base;
using Telos.Admin.Model;

namespace Telos.Admin.Data.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>
    {
        public AlunoRepository(DatabaseControlContext context)
            : base(context)
        {
        }


        public virtual Aluno FindByCode(long code)
        {
            return this.dbSet.Find(code);
        }
    }
}
