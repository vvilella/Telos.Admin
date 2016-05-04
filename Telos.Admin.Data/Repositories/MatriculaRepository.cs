using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telos.Admin.Data.Base;
using Telos.Admin.Model;

namespace Telos.Admin.Data.Repositories
{
    public class MatriculaRepository : BaseRepository<Matricula>
    {
        public MatriculaRepository(DatabaseControlContext context)
            : base(context)
        {
        }


        public virtual Matricula FindByCode(string code)
        {
            return this.dbSet.Find(code);
        }

        public virtual List<Matricula> FindByAluno(Aluno aluno)
        {
            if (aluno == null && String.IsNullOrEmpty(aluno.CpfCode))
                return null;

            return this.dbSet.Where(i => i.Aluno.CpfCode.Equals(aluno.CpfCode)).ToList();
        }

        public virtual List<Matricula> FindByProfessor(Professor professor)
        {
            if (professor == null && String.IsNullOrEmpty(professor.CpfCode))
                return null;

            return this.dbSet.Where(i => i.Professor.CpfCode.Equals(professor.CpfCode)).ToList();
        }

        public virtual List<Matricula> FindByCurso(Curso curso)
        {
            if (curso == null && String.IsNullOrEmpty(curso.CursoCode))
                return null;

            return this.dbSet.Where(i => i.Curso.CursoCode.Equals(curso.CursoCode)).ToList();
        }

        public virtual List<Matricula> FindByUnidade(Unidade unidade)
        {
            if (unidade == null && String.IsNullOrEmpty(unidade.UnidadeCode))
                return null;

            return this.dbSet.Where(i => i.Unidade.UnidadeCode.Equals(unidade.UnidadeCode)).ToList();
        }


    }
}
