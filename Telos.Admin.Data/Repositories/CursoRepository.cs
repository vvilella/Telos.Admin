using Telos.Admin.Data.Base;
using Telos.Admin.Model;

namespace Telos.Admin.Data.Repositories
{
    public class CursoRepository : BaseRepository<Curso>
    {
        public CursoRepository(DatabaseControlContext context)
            : base(context)
        {
        }
        
        public virtual Curso FindByCode(string code)
        {
            return this.dbSet.Find(code);
        }
    }
}
