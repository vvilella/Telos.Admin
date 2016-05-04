using Telos.Admin.Data.Base;
using Telos.Admin.Model;

namespace Telos.Admin.Data.Repositories
{
    public class UnidadeRepository : BaseRepository<Unidade>
    {
        public UnidadeRepository(DatabaseControlContext context)
            : base(context)
        {
        }


        public virtual Unidade FindByCode(string code)
        {
            return this.dbSet.Find(code);
        }
    }
}
