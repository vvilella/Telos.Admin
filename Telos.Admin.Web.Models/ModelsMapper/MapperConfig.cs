using AutoMapper;
using Telos.Admin.Model;

namespace Telos.Admin.Web.Models.ModelsMapper
{
    public class MapperConfig
    {
        public static void InitMaps()
        {
            Mapper.CreateMap<Unidade, UnidadeModel>();
            Mapper.CreateMap<UnidadeModel, Unidade>();

            Mapper.CreateMap<Aluno, AlunoModel>();
            Mapper.CreateMap<AlunoModel, Aluno>();

            Mapper.CreateMap<Professor, ProfessorModel>();
            Mapper.CreateMap<ProfessorModel, Professor>();

            Mapper.CreateMap<Curso, CursoModel>();
            Mapper.CreateMap<CursoModel, Curso>();

            Mapper.CreateMap<Matricula, MatriculaModel>();
            Mapper.CreateMap<MatriculaModel, Matricula>();
        }
    }
}
