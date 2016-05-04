using Telos.Admin.Data.Base;
using Telos.Admin.Model;

namespace Telos.Admin.Data.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>
    {
        public ProfessorRepository(DatabaseControlContext context)
            : base(context)
        {
        }


        public virtual Professor FindByCode(string code)
        {
            return this.dbSet.Find(code);
        }
    }
}
