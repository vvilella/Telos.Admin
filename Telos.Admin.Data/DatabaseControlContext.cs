using System.Data.Entity;
using Clutch.Diagnostics.EntityFramework;
using Telos.Admin.Model;
using Telos.Admin.Infrastructure;
using CTelos.Admin.Data;

namespace Telos.Admin.Data
{
    public class DatabaseControlContext : DbContext, IDatabaseControlContext
    {
        public DatabaseControlContext()
        {
            DbTracing.Enable();
            DbTracing.AddListener(new DatabaseControlContextTracer());
            Database.SetInitializer<DatabaseControlContext>(new DropCreateDatabaseIfModelChanges<DatabaseControlContext>());
        }

        #region Telos
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        #endregion

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
